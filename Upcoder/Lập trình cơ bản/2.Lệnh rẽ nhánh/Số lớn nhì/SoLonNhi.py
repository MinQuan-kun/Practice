a, b, c, d = map(int, input().split())
if a == b == c == d:
    print("-1", end='')
else:
    Max = max(a, b, c, d)
    Min = min(a, b, c, d)
    Max2 = Min
    if Max2 < a and a != Max:
        Max2 = a
    if Max2 < b and b != Max:
        Max2 = b
    if Max2 < c and c != Max:
        Max2 = c
    if Max2 < d and d != Max:
        Max2 = d
    print(Max2, end='')
