import math

a, x = map(float, input().split())
if x < -math.pi or x > math.pi:
    exit(1)

S = (a + math.sin(x)) / math.sqrt(a**2 + x**2 + 1)
S = round(S, 6)
print(S)
