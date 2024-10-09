def tinh_tong(n):
    total = 0.0
    for i in range(1, n + 1):
        total += 1.0 / (i ** 3)
    return total

n = int(input())
if(n == 1):
    print(1,end="")
else:
    s = round(tinh_tong(n), 3)
    print(s, end="")
