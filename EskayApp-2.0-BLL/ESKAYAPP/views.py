# DJANGO-VIEWS, KNN ALGORITHM ESKAYA CHARACTER RECOGNITION
# Copyright 2021 ᜋᜃᜐ Makasa <maxangelo.perin@cit.edu>

from rest_framework.decorators import api_view
from django.http import JsonResponse
import cv2
import numpy as np
import operator
import os
import time
from PIL import Image

# Module level variables
MIN_CONTOUR_AREA = 100
RESIZED_IMAGE_WIDTH = 20
RESIZED_IMAGE_HEIGHT = 30

# Countour Data Class
class ContourWithData():

    # Member Variables
    npaContour = None           # contour
    boundingRect = None         # bounding rect for contour
    intRectX = 0                # bounding rect top left corner x location
    intRectY = 0                # bounding rect top left corner y location
    intRectWidth = 0            # bounding rect width
    intRectHeight = 0           # bounding rect height
    fltArea = 0.0               # area of contour

    def calculateRectTopLeftPointAndWidthAndHeight(self):               # calculate bounding rect info
        [intX, intY, intWidth, intHeight] = self.boundingRect
        self.intRectX = intX
        self.intRectY = intY
        self.intRectWidth = intWidth
        self.intRectHeight = intHeight

    def checkIfContourIsValid(self):                                    # this is oversimplified, for a production grade program
        if self.fltArea < MIN_CONTOUR_AREA: return False                # much better validity checking would be necessary
        return True

from django.core.files.storage import FileSystemStorage

###################################################################################################
# Create your views here.
@api_view(["POST"])
def WakeUp(request):
    return JsonResponse("OK", safe=False)

@api_view(["POST"])
def CheckImage(request):
    # Request Photo, form-data, Key= eskaya_photo
    myfile = request.FILES['eskaya_photo']
    fs = FileSystemStorage()
    filename = fs.save(myfile.name, myfile)

    # Resize photo to 100x100
    img = Image.open("media/"+filename)  # image extension *.png,*.jpg
    new_width = 50
    new_height = 50
    img = img.resize((new_width, new_height), Image.ANTIALIAS)
    img.save("media/"+filename)  # format may what you want *.png, *jpg, *.gif
    print("Fileneme: "+filename)

    allContoursWithData = []                # declare empty lists,
    validContoursWithData = []              # we will fill these shortly
    s = time.time()
    print("START...")
    try:
        print("LOAD CLASSIFICATIONS... ")
        npaClassifications =np.load('CLASSIFICATIONS.npy')                              # read in training classifications
    except:
        print("Error, unable to open classifications.txt, exiting program\n")
        os.system("pause")
        return
    # end try

    try:
        print("LOAD FLATTENED IMAGES...")
        npaFlattenedImages = np.load('FLATTENED_IMAGES.npy')
        print(npaFlattenedImages)
        print(type(npaFlattenedImages))

    except:
        print("Error, unable to open flattened_images.txt, exiting program\n")
        os.system("pause")
        return
    # end try

    print("START K-NEAREST")
    npaClassifications = npaClassifications.reshape((npaClassifications.size, 1))       # reshape numpy array to 1d, necessary to pass to call to train

    kNearest = cv2.ml.KNearest_create()                                                 # instantiate KNN object

    kNearest.train(npaFlattenedImages, cv2.ml.ROW_SAMPLE, npaClassifications)

    imgTestingNumbers = cv2.imread("media/"+filename)                                   # read in testing numbers image

    if imgTestingNumbers is None:                                                       # if image was not read successfully
        os.system("pause")                                                              # pause so user can see error message
        return JsonResponse("Error: image not read from file \n\n")                     # and exit function (which exits program)
    # end if

    imgGray = cv2.cvtColor(imgTestingNumbers, cv2.COLOR_BGR2GRAY)           # get grayscale image
    imgBlurred = cv2.GaussianBlur(imgGray, (5,5), 0)                        # blur

                                                                            # filter image from grayscale to black and white
    imgThresh = cv2.adaptiveThreshold(imgBlurred,                           # input image
                                      255,                                  # make pixels that pass the threshold full white
                                      cv2.ADAPTIVE_THRESH_GAUSSIAN_C,       # use gaussian rather than mean, seems to give better results
                                      cv2.THRESH_BINARY_INV,                # invert so foreground will be white, background will be black
                                      11,                                   # size of a pixel neighborhood used to calculate threshold value
                                      2)                                    # constant subtracted from the mean or weighted mean

    imgThreshCopy = imgThresh.copy()                                        # make a copy of the thresh image, this in necessary b/c findContours modifies the image

    npaContours, npaHierarchy = cv2.findContours(imgThreshCopy,             # input image, make sure to use a copy since the function will modify this image in the course of finding contours
                                                 cv2.RETR_EXTERNAL,         # retrieve the outermost contours only
                                                 cv2.CHAIN_APPROX_SIMPLE)   # compress horizontal, vertical, and diagonal segments and leave only their end points

    for npaContour in npaContours:                                                      # for each contour
        contourWithData = ContourWithData()                                             # instantiate a contour with data object
        contourWithData.npaContour = npaContour                                         # assign contour to contour with data
        contourWithData.boundingRect = cv2.boundingRect(contourWithData.npaContour)     # get the bounding rect
        contourWithData.calculateRectTopLeftPointAndWidthAndHeight()                    # get bounding rect info
        contourWithData.fltArea = cv2.contourArea(contourWithData.npaContour)           # calculate the contour area
        allContoursWithData.append(contourWithData)                                     # add contour with data object to list of all contours with data
    # end for

    for contourWithData in allContoursWithData:                 # for all contours
        if contourWithData.checkIfContourIsValid():             # check if valid
            validContoursWithData.append(contourWithData)       # if so, append to valid contour list
        # end if
    # end for

    validContoursWithData.sort(key = operator.attrgetter("intRectX"))         # sort contours from left to right

    strFinalString = ""                                                       # declare final string, this will have the final number sequence by the end of the program

    for contourWithData in validContoursWithData:
        imgROI = imgThresh[contourWithData.intRectY : contourWithData.intRectY + contourWithData.intRectHeight,     # crop char out of threshold image
                           contourWithData.intRectX : contourWithData.intRectX + contourWithData.intRectWidth]

        imgROIResized = cv2.resize(imgROI, (RESIZED_IMAGE_WIDTH, RESIZED_IMAGE_HEIGHT))             # resize image, this will be more consistent for recognition and storage
        npaROIResized = imgROIResized.reshape((1, RESIZED_IMAGE_WIDTH * RESIZED_IMAGE_HEIGHT))      # flatten image into 1d numpy array
        npaROIResized = np.float32(npaROIResized)                                                   # convert from 1d numpy array of ints to 1d numpy array of floats
        retval, npaResults, neigh_resp, dists = kNearest.findNearest(npaROIResized, k = 1)          # call KNN function find_nearest
        strCurrentChar = str(chr(int(npaResults[0][0])))                                            # get character from results
        strFinalString = strFinalString + strCurrentChar                                            # append current char to full string
    # end for

    print("Final Character: " + strFinalString)  # show the full string

    e = time.time()
    total_time = e-s
    print("Time take to process: "+str(total_time)+" seconds")


    # Delete Photo After Processed
    if os.path.exists("media/"+filename):
        os.remove("media/"+filename)
    else:
        print("The file does not exist")

    # Return JSON Final String Input
    return JsonResponse(strFinalString, safe=False)