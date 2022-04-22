from PIL import Image

letters = ["Ar","Boy","Cho","Cion","Cod","Conn","Gru","Gue","Ke","Kre","Ngo","Ngoy","Ning","Ny","Nya","Pa","Pag","Pre","Sa","Tao","Ted","Was"]

for ch in letters:
    for x in range(360):
        y = 'ESKAYA-'+ch+'/rotated'+str(x)+'.png'
        print(y)
        input = Image.open(y)
        image = Image.new("RGB", input.size, "WHITE")
        image.paste(input, (0, 0), input)
        y_o = 'ESKAYA-'+ch+'/rotatedwhite'+str(x)+'.png'
        image.save(y_o)



