x = int(input())
tien = 2500
if(x < 0):
    print("NHAP SAI", end ="")
else:
    if(x <= 50):
        tien *= x
    elif(x >= 51 and x <= 100):
        tien = tien * 50 + (x - 50) * 3000
    elif(x >= 101 and x <= 200):
        tien = tien * 50 + 3000 * 50 + (x - 100) * 5000
    elif(x > 200):
        tien = -1
    if(tien == -1):
        print("CAT DIEN", end="")
    else:
        print(tien)