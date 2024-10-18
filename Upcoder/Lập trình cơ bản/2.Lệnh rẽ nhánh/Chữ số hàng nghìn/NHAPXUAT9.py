# Nhập số nguyên A
A = int(input())

if A > 999:
    A //= 1000  # Sử dụng // để chia nguyên trong Python
    print(A % 10, end="")
else:
    print("-1", end="")
