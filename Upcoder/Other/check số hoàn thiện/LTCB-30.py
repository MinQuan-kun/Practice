def check_sht(x):
    if x <= 1:
        return False
    tong = 0
    for i in range(1, x // 2 + 1):
        if x % i == 0:
            tong += i
    return tong == x

if __name__ == "__main__":
    n = int(input())
    if check_sht(n):
        print("YES")
    else:
        print("NO")
