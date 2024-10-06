# Nhập ngày đến và ngày đi
arrival, departure = map(int, input().split())

# Kiểm tra tính hợp lệ của ngày đến và ngày đi
if arrival < 1 or arrival > 7 or departure < 1 or departure > 7:
    print("NHAP SAI", end="")
else:
    # Tính số đêm
    total_nights = 0
    if departure >= arrival:
        total_nights = departure - arrival
    else:
        total_nights = (7 - arrival) + departure  # Tính toán qua cuối tuần

    # Tính tiền
    total_cost = 0
    for i in range(total_nights):
        current_day = (arrival + i - 1) % 7 + 1  # Lấy ngày hiện tại
        if current_day == 1:  # Chủ Nhật
            total_cost += 400000
        else:
            total_cost += 300000

    # Xuất ra số tiền phải trả
    print(total_cost, end="")
