# Nhập số nguyên A
A = int(input())

if A < 17:
    N = A * 7000
    print(N, end="")
else:
    if A < 51:
        N = (A - 16) * 8500 + 16 * 7000
        print(N,end ="")
    else:
        N = (A - 50) * 100000 + 34 * 8500 + 16 * 7000
        print(N, end="")
