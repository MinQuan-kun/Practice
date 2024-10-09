def Dequy(n):
    result = 1.0 / 2.0 + 3.0 / 4.0
    for i in range(2, n + 1):
        result += (2 * i + 1.0) / (2 * i + 2.0)
    return result

n = int(input())
if n == 0:
    print(1.0 / 2.0)
else:
    print(Dequy(n), end="")
