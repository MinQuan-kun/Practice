a = int(input())
check = "true"
if(a < 2):
    check = "false"
for i in range (2, int(a**0.5) + 1):
    if (a % i == 0):
        check = "false"
print(check, end="")
