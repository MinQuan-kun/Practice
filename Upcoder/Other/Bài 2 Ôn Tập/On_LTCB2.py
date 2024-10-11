a , b = map(int , input().split())
A = 0 
B = 0
if(a % 2 == 0):
    A = a
else:
    A = -a
if(b % 2 != 0):
    B = b
else:
    B = -b
print(A * B, end="")