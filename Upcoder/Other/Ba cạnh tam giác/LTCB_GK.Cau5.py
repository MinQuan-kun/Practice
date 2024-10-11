import math
a, b, c = map(int , input().split())
if (a > 0 and b > 0 and c > 0 and a + b > c and a + c > b and b + c > a): 
    p = (a + b + c) / 2.0
    S = math.sqrt(p * (p - a) * (p - b) * (p - c))
    perimeter = a + b + c
    print(perimeter,int(S)) 
else:
    print("Khong phai tam giac", end="")