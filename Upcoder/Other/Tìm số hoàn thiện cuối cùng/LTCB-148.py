def isPerfect(x):
    if x < 2:
        return False
    tong = 1 
    for i in range(2, int(x**0.5) + 1):
        if x % i == 0:
            tong += i
            if i != x // i:
                tong += x // i
    return tong == x

arr = []
for i in range(5):
    arr.append(int(input("Nhập số: ")))

last_perfect = -1
for num in arr:
    if isPerfect(num):
        last_perfect = num

print("Số hoàn hảo cuối cùng:", last_perfect)
