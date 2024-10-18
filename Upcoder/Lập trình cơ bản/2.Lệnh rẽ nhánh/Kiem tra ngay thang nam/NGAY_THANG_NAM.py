d, m, y = map(int, input().split())
if((y >= 1900) and ((y % 400 == 0) or (y % 4 == 0)) and (y % 100 != 0) and m == 2 and d <= 29):
    print("YES", end="")
elif((y >= 1900) and ((y % 400 != 0) or (y % 4 == 0)) and (y % 100!= 0)and m==2 and d<=28):
    print("YES", end="")
elif((y >= 1900) and (m == 1 or m == 3 or m == 5 or m == 7 or m == 8 or m == 10 or m == 12) and d <= 31):
    print("YES", end="")
elif((y >= 1900) and (m == 4 or m == 6 or m == 9 or m == 11) and d <= 30):
    print("YES",end= "")
else:
    print("NO",end= "")