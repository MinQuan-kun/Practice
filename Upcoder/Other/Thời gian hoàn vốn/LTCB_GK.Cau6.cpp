#include <iostream>
using namespace std;

int main() {
    double a;  
    cin >> a; 
    
    double current_money = a;  // Số tiền hiện tại của Mr. An
    int months = 0;            // Biến đếm số tháng
    
    // Mỗi tháng Mr. An lời 10%, tiếp tục cho đến khi hoàn vốn
    while (current_money < 2 * a) {
        current_money += current_money * 0.1;  // Cộng thêm 10% của tổng số tiền
        months++;
    }

    cout << months;
    
    return 0;
}
