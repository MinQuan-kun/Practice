#code này chỉ có Điểm 3.75
a = input()
n, m = map(int, input().split())
if n < 0 or m > len(a):
    print("gioi han khong dung", end="")
else:
    sub_string = a[slice(n, m + 1)]
    print(sub_string, end="")
