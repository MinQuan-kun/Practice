n = int(input())
tong = 0
for i in range (1, n + 1):
    if(i % 5 == 0):
        tong += i
print(tong, end="")