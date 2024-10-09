n = int(input())
tong = 0
kq = 0

for i in range(1, n):
    tong += i
    if tong > n:
        break
    kq = i

print(kq, end="")
