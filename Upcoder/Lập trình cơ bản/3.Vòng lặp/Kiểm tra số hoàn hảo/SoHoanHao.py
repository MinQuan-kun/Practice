
a = int(input())
tong = 0
for i in range (1 , a):
    if a % i == 0:
        tong = tong + i

if tong == a:
    print("Yes", end="")
else:
    print("No", end= "")