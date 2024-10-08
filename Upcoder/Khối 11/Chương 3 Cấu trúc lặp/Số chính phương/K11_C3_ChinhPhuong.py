import math
n = int(input())
if n < 0:
    print("False",end="")
else:
    sqrt_n = math.sqrt(n)
    if sqrt_n == int(sqrt_n):
        print("True", end="")
    else:
        print("False", end="")
