def DequyS(n):
    if n == 1:
        return 0.5
    return DequyS(n - 1) + (1.0 / (2 * n))

n = int(input())
print(round(DequyS(n),3), end = "")  # In kết quả với 3 chữ số thập phân
