n = int(input())  # Nhập giá trị n từ bàn phím
s = 0  # Khởi tạo tổng bằng 0

if n < 0:
    print("NHAP SAI")  # Nếu n nhỏ hơn 0 thì xuất "NHAP SAI"
else:
    for i in range(n + 1):  # Vòng lặp từ 0 đến n
        s += i  # Cộng dồn các giá trị từ 0 đến n vào s
    print(s)  # In tổng giá trị
