#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;

    // Tách các chữ số
    int a = n / 1000;
    int b = (n / 100) % 10;
    int c = (n / 10) % 10;
    int d = n % 10;

    // Khởi tạo Max và Min
    int Max = a;
    int Min = a;

    // Tìm giá trị lớn nhất
    if (Max < b) Max = b;
    if (Max < c) Max = c;
    if (Max < d) Max = d;

    // Tìm giá trị nhỏ nhất
    if (Min > b) Min = b;
    if (Min > c) Min = c;
    if (Min > d) Min = d;

    // Xuất tổng của giá trị lớn nhất và nhỏ nhất
    cout << "Tổng của giá trị lớn nhất và nhỏ nhất là: " << Max + Min << endl;

    return 0;
}
