x, n = map(float, input().split())
if(x < 0 or n < 0):
    print(0)
else:
    tien = 0
    temp = x
    for i in range(int(n) + 1, 12 + 1):
        tien = x + (temp * 0.05)
        temp = x + temp * 0.05
    print(tien)