n = int(input("Nhập một số nguyên (có 4 chữ số): "))

# Tách các chữ số
a = n // 1000
b = (n // 100) % 10
c = (n // 10) % 10
d = n % 10

# Khởi tạo Max và Min
Max = a
Min = a

# Tìm giá trị lớn nhất
if Max < b:
    Max = b
if Max < c:
    Max = c
if Max < d:
    Max = d

# Tìm giá trị nhỏ nhất
if Min > b:
    Min = b
if Min > c:
    Min = c
if Min > d:
    Min = d

# Xuất tổng của giá trị lớn nhất và nhỏ nhất
print(Max + Min)
