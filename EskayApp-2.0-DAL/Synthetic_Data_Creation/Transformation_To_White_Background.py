from PIL import Image

letters = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","X","Y"]
for ch in letters:
    for x in range(360):
        y = 'ESKAYA-'+ch+'/rotated'+str(x)+'.png'
        print(y)
        input = Image.open(y)
        image = Image.new("RGB", input.size, "WHITE")
        image.paste(input, (0, 0), input)
        y_o = 'ESKAYA-'+ch+'/rotatedwhite'+str(x)+'.png'
        image.save(y_o)



