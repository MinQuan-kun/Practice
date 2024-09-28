#include <iostream>
#include <stack>
using namespace std;
// Hàm chuyển đổi từ hệ cơ số 10 sang hệ cơ số 2
void xuly(int n) 
{
    stack<int> coso;
    // Chuyển đổi
    while (n > 0) 
    {
        int value = n % 2; // Lấy phần dư khi chia cho 2
        coso.push(value); // Đẩy phần dư vào ngăn xếp
        n /= 2; // Chia cho 2 để tiếp tục chuyển đổi
    }
    // In kết quả
    while (!coso.empty()) 
    {
        cout << coso.top(); // Lấy phần tử ở đầu ngăn xếp
        coso.pop(); // Xóa phần tử ở đầu ngăn xếp
    }
}
int main() 
{
    int n;
    cin >> n;
    if (n == 0) 
    {
        cout<<0;
        return 0;
    }
    xuly(n);

    return 0;
}