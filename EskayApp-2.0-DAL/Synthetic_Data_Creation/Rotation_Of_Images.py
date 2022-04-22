from PIL import Image
letters = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","X","Y"]
for ch in letters:
    for x in range(360):
        title = ch + ".png"
        im = Image.open(title)
        im = im.rotate(x, expand=True)
        y = 'ESKAYA-'+ch+'/rotated'+str(x)+'.png'
        print(y)
        im.save(y)

