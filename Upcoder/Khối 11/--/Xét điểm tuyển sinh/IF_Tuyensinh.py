def main():
    # Nhập điểm chuẩn
    diem_chuan = float(input())

    # Nhập điểm thi 3 môn
    diem_mons = list(map(float, input().split()))
    diem_mon1, diem_mon2, diem_mon3 = diem_mons

    # Nhập khu vực
    khu_vuc = input().strip()

    # Nhập đối tượng
    doi_tuong = int(input())

    # Tính điểm ưu tiên
    diem_uu_tien = 0
    if khu_vuc == 'A':
        diem_uu_tien += 2
    elif khu_vuc == 'B':
        diem_uu_tien += 1
    elif khu_vuc == 'C':
        diem_uu_tien += 0.5

    if doi_tuong == 1:
        diem_uu_tien += 2.5
    elif doi_tuong == 2:
        diem_uu_tien += 1.5
    elif doi_tuong == 3:
        diem_uu_tien += 1

    # Tính điểm tổng kết
    tong_diem = diem_mon1 + diem_mon2 + diem_mon3 + diem_uu_tien

    # Kiểm tra điều kiện đậu
    if tong_diem >= diem_chuan and diem_mon1 > 0 and diem_mon2 > 0 and diem_mon3 > 0:
        print("PASS", end="")
    else:
        print("FAIL", end="")

if __name__ == "__main__":
    main()
