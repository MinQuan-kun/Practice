#include <iostream>
#include <stack>
using namespace std;
// Hàm chuyển đổi từ hệ cơ số 10 sang hệ cơ số 2, 8 hoặc 16
void chuyenCoSo(long soHe10, int heCoSoMoi = 0) 
{
    stack<char> nganXepKetQua;
    int coSo;
    // Xác định hệ cơ số mới
    if (heCoSoMoi == 1)
        coSo = 8;
    else if (heCoSoMoi == 2) 
        coSo = 16;
    else 
        coSo = 2;
    // Chuyển đổi số từ hệ 10 sang hệ mới
    while (soHe10 > 0) 
    {
        int phanDu = soHe10 % coSo;
        // Chuyển đổi phần dư thành ký tự tương ứng
        if (phanDu < 10) 
            nganXepKetQua.push(phanDu + '0');
        else 
            nganXepKetQua.push((phanDu - 10) + 'A');
        soHe10 /= coSo;
    }
    // Xuất kết quả
    while (!nganXepKetQua.empty()) 
    {
        cout << nganXepKetQua.top();
        nganXepKetQua.pop();
    }
    cout << endl;
}
int main() 
{
    long n;
    int heCoSo;
    cin >> n >> heCoSo;

    if (heCoSo >= 0 && heCoSo <= 2)
        chuyenCoSo(n, heCoSo);
    else 
        cout << 0;
    return 0;
}