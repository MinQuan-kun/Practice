a, b, c = map(int, input().split())
max = a
if max < b:
    max = b
if max < c:
    max = c
min = a
if min > b:
    min = b
if min > c:
    min = c
print(max,min, end="")