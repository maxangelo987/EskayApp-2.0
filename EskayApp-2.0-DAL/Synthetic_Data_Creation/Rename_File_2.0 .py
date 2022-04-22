import os
letters = ["Ar","Boy","Cho","Cion","Cod","Conn","Gru","Gue","Ke","Kre","Ngo","Ngoy","Ning","Ny","Nya","Pa","Pag","Pre","Sa","Tao","Ted","Was"]

for ch in letters:
    old_file = os.path.join("D:\OpenCV_3_KNN_Eskayan_Character_Recognition_Python_Windows\Synthetic_Data_Creation\ESKAYA-"+ch, ch+".png")
    new_file = os.path.join("D:\OpenCV_3_KNN_Eskayan_Character_Recognition_Python_Windows\Synthetic_Data_Creation\ESKAYA-"+ch, "rotatedwhite0.png")
    os.rename(old_file, new_file)
