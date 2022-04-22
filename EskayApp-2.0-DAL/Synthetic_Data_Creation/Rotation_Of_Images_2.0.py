from PIL import Image
letters = ["Ar","Boy","Cho","Cion","Cod","Conn","Gru","Gue","Ke","Kre","Ngo","Ngoy","Ning","Ny","Nya","Pa","Pag","Pre","Sa","Tao","Ted","Was"]
for ch in letters:
    for x in range(360):
        title = ch + ".png"
        im = Image.open(title)
        im = im.rotate(x, expand=True)
        y = 'ESKAYA-'+ch+'/rotated'+str(x)+'.png'
        print(y)
        im.save(y)

