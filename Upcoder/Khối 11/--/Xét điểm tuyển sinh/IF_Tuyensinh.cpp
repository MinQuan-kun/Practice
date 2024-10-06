#include <iostream>

using namespace std;

int main() {
    // Nhập điểm chuẩn
    float diem_chuan;
    cin >> diem_chuan;
    // Nhập điểm thi 3 môn
    float diem_mon1, diem_mon2, diem_mon3;
    cin >> diem_mon1;
    cin >> diem_mon2;
    cin >> diem_mon3;
    // Nhập khu vực
    char khu_vuc;
    cin >> khu_vuc;
    // Nhập đối tượng dự thi
    int doi_tuong;
    cin >> doi_tuong;
    // Tính điểm ưu tiên
    float diem_uu_tien = 0;
    switch (khu_vuc) {
        case 'A':
            diem_uu_tien += 2;
            break;
        case 'B':
            diem_uu_tien += 1;
            break;
        case 'C':
            diem_uu_tien += 0.5;
            break;
        default:
            diem_uu_tien+=0;
            return 0;
    }

    switch (doi_tuong) {
        case 1:
            diem_uu_tien += 2.5;
            break;
        case 2:
            diem_uu_tien += 1.5;
            break;
        case 3:
            diem_uu_tien += 1;
            break;
        default:
            diem_uu_tien +=0;
            return 0;
    }

    // Tính điểm tổng kết
    float diem_tong_ket = diem_mon1 + diem_mon2 + diem_mon3 + diem_uu_tien;
    // Kiểm tra thí sinh đậu hay rớt
    if (diem_tong_ket >= diem_chuan && diem_mon1 > 0 && diem_mon2 > 0 && diem_mon3 > 0) {
        cout << "PASS" << endl;
    } else {
        cout << "FAIL" << endl;
    }
    return 0;
}