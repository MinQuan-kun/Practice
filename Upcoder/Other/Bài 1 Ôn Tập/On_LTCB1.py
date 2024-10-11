a , b = map(int, input().split())
check = False
if (a + b >= 0):
    print(a + b, "",end="")
    check = True
if (a - b >= 0):
    print(a - b, "",end="")
    check = True
if (a * b >= 0):
    print(a * b , end="")
    check = True
if (check == False):
    print("impossible", end="")
