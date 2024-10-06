a = int(input())
check = ""
for i in range(0,a):
    if i * i == a:
        check = "true"
if check == "true":
    print("yes", end="")
else:
    print("no", end="")
    