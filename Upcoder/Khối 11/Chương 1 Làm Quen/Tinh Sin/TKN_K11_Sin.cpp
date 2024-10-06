#include <iostream>
#include <cmath>

int main() {
    // Khai báo biến
    float a, x, S;

    // Nhập giá trị cho a và x
    std::cin >> a;
    std::cin >> x;

    // Kiểm tra x có nằm trong khoảng -pi đến pi không
    if (x < -M_PI || x > M_PI) {
        return 1;  // Kết thúc chương trình với mã lỗi
    }

    // Tính giá trị biểu thức S
    S = (a + sin(x)) / sqrt(a*a + x*x +1 );

    // Xuất giá trị S ra màn hình
    std::cout << S << std::endl;

    return 0;
}