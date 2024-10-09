def DequyS(n):
    if n == 1:
        return 1
    return n + DequyS(n - 1)

def DequyX(x, n):
    if n == 1:
        return x
    return DequyX(x, n - 1) + (x ** n) / DequyS(n)

x, n = map(int, input().split())
print(DequyX(x, n), end="")
