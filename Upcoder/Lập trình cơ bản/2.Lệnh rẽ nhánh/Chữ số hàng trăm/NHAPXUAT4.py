a = int(input())
count = 0
while a != 0:
    temp = a % 10
    count += 1
    if count == 3:
        res = temp
    a //= 10
if count < 3:
    print(-1, end="")
else:
    print(res, end="")