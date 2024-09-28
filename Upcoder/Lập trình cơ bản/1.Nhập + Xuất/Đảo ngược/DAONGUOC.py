a = int(input())
tong = 0
while a != 0:
    tong = tong * 10 + a % 10
    a //= 10
print(tong, end='')