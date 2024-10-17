#Code lụm :D
try:
    # Nhập A và B trên cùng một dòng
    inputs = input().split()

    # Kiểm tra số lượng giá trị đã nhập
    if len(inputs) == 2:
        A, B = map(int, inputs)
    elif len(inputs) == 1:
        # Nếu chỉ nhập một giá trị, yêu cầu nhập tiếp
        A = int(inputs[0])
        B = int(input())
    else:
        raise ValueError(0)

    if A == 0:
        if B == 0:
            print('VSN')  # Vô số nghiệm
        else:
            print("VN")   # Vô nghiệm
    else:
        x = -B / A
        x = "{:.2f}".format(x)  # Định dạng ra 2 chữ số thập phân
        print(x)

except ValueError as e:
    print(0, e)
