# Đọc đầu vào
input_expression = input()

# Lấy hai chữ số và phép toán
a = int(input_expression[:2])  # Lấy 2 chữ số đầu tiên
op = input_expression[2]        # Lấy phép toán
b = int(input_expression[3:5])  # Lấy 2 chữ số tiếp theo

# Thực hiện phép toán và xuất kết quả
if op == '+':
    result = a + b
    print("{}+{}={}".format(a, b, result), end="")  # In ra phép toán
elif op == '-':
    result = a - b
    print("{}-{}={}".format(a, b, result), end="")  # In ra phép toán
else:
    print("Phép toán không hợp lệ.")
    exit()
