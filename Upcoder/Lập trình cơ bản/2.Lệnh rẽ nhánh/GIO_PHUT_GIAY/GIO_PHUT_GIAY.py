# Nhập giờ, phút, giây
gio, phut, giay = map(int, input().split())

# Kiểm tra giá trị hợp lệ
if gio > 23 or phut > 59 or giay > 59:
    print("NO")
else:
    print("YES")
    
    # Tăng giây
    if giay == 59:
        phut += 1
        giay = 0
    else:
        giay += 1

    # Kiểm tra phút
    if phut > 59:
        gio += 1
        phut = 0
        giay = 0

    # Kiểm tra giờ
    if gio > 23:
        gio = 0
        phut = 0
        giay = 0

    # Xuất giờ, phút, giây
    print("{}:{}:{}".format(gio, phut, giay), end="")
