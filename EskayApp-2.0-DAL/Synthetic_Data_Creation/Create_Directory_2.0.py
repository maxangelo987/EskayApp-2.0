import os

letters = ["Ar","Boy","Cho","Cion","Cod","Conn","Gru","Gue","Ke","Kre","Ngo","Ngoy","Ning","Ny","Nya","Pa","Pag","Pre","Sa","Tao","Ted","Was"]

for ch in letters:
    newpath = r'D:\OpenCV_3_KNN_Eskayan_Character_Recognition_Python_Windows\Synthetic_Data_Creation'+'\ESKAYA-'+ch
    if not os.path.exists(newpath):
        os.makedirs(newpath)

