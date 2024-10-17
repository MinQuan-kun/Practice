# Nhập dữ liệu từ bàn phím
input_data = input().split()
T = int(input_data[0])
P = int(input_data[1])
C = int(input_data[2])

if T == 1:
    A4 = P * C
    print(A4)
elif T == 2:
    if P % 2 == 0:
        A4 = (P // 2) * C
    else:
        A4 = ((P + 1) // 2) * C
    print(A4)
