x, n = map(int, input().split())  # Nhập giá trị x và n từ bàn phím

if n < 0:
    print(1)
elif n == 0:
    print(1)
else:
    s = x  # Khởi tạo s = x
    for i in range(1, n):  # Vòng lặp từ 1 đến n-1
        s *= x  # Nhân s với x ở mỗi vòng lặp
    print(s)  # In ra kết quả
