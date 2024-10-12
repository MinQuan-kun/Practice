#code này chưa chấm trên upcoder
a, b, c = map(int, input().split())
Max = a
if(Max < b):
    Max = b
if(Max < c):
    Max = c
Min = a
if(Min > b):
    Min = b
if(Min > c):
    Min = c
medium = a
if ((b > Min and b < Max) or (b > Max and b < Min)):
    medium = b
if ((c > Min and c < Max) or (c > Max and c < Min)):
    medium = c
if (medium % 2 == 0):
    print(medium,"la so chan", end="")
else:
    print(medium,"la so le", end="")