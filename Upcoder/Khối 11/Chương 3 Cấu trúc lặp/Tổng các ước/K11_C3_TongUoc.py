n = int(input())
if(n < 0):
    n *= -1
tong = 0
for i in range (1, n + 1):
    if(n % i == 0):
        tong += i
print(tong, end="")