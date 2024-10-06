import math
x = float(input())
T = math.sqrt(x + math.sqrt(x + math.sqrt(x)))
T = round(T, 5)
print(T, end="")
