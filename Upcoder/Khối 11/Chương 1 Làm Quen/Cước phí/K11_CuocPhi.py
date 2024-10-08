x = float(input())
tien = 3000
if (x < 0):
    print("NHAP SAI", end="")
else:
    if( x - int(x) >= 0.5):
        x = int(x) + 1
    else:
        x = int(x)
    if(x == 0):
        tien = 0
    elif(x == 1):
        tien = 3000
    elif(x >= 2 and x <= 10):
        tien = tien + (x - 1) * 2000
    elif(x >= 11):
        tien = tien + 9 * 2000 + (x - 10) * 1500
    print(tien, end="")