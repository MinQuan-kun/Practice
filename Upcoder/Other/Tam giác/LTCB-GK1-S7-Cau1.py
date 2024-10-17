while True:
    # Nhập vào 3 số nguyên a, b, c
    input_expression = input()
    if not input_expression:
        break

    parts = input_expression.split()
    if len(parts) < 3:
        break

    a = int(parts[0])
    b = int(parts[1])
    c = int(parts[2])

    # Kiểm tra tính hợp lệ của 3 cạnh
    if a > 0 and b > 0 and c > 0 and (a + b > c) and (a + c > b) and (b + c > a):
        perimeter = a + b + c
        print(perimeter)
    else:
        print("NO")
