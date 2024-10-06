a, b = map(int, input().split())
c = str(input())
if c == "+":
    tong = a + b
if c == "-":
    tong = a - b
if c == "*":
    tong = a * b
if c == "%":
    tong = a % b
print (str(a) + c + str(b) + "=" +str(tong), end ="")
