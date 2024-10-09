n = int(input())
a = n // 1000
b = (n // 100) % 10
c = (n // 10) % 10
d = n % 10
max_val = max(a, b, c, d)
min_val = min(a, b, c, d)
print(max_val + min_val, end="")
