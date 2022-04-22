from PIL import Image
letters = ["Ar","Boy","Cho","Cion","Cod","Conn","Gru","Gue","Ke","Kre","Ngo","Ngoy","Ning","Ny","Nya","Pa","Pag","Pre","Sa","Tao","Ted","Was"]

for ch in letters:
    im = Image.open('D:\OpenCV_3_KNN_Eskayan_Character_Recognition_Python_Windows\Synthetic_Data_Creation\ESKAYA-'+ch+'\\'+'rotated0.jpg')
    im.save('D:\OpenCV_3_KNN_Eskayan_Character_Recognition_Python_Windows\Synthetic_Data_Creation\ESKAYA-'+ch+'\\'+'rotated0.png')