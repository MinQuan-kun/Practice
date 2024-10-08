import math

a ,b ,C = map(float, input().split())
if(C == 180):
    print("KHONG PHAI TAM GIAC", end ="")
else:
    C *= math.pi / 180
    c = math.sqrt( a * a + b * b - 2 * a * b * math.cos(C))
    print(c)