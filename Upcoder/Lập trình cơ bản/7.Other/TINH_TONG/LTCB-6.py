def DequyS(x, n):
    if n == 0:
        return 0
    else:
        return 1.0 / (n * x * (n + 1)) + DequyS(x, n - 1)

# Nhập giá trị x và n
x, n = map(int, input().split())

# Tính giá trị s
if x < 0 or n < 0:
    print(-1)
else:
    s = DequyS(x, n)
    print(f"{s:.3f}")
