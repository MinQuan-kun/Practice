#include <bits/stdc++.h>
using namespace std;

double DequyS(int n)
{
    if (n == 1)
        return 1.0/2.0;
    return DequyS(n - 1) + (1.0 / (2 * n));  // Sửa 1 thành 1.0 để đảm bảo chia số thực
}

int main()
{
    int n;
    cin >> n;
    cout << fixed << setprecision(3) << DequyS(n);  // In kết quả với 3 chữ số thập phân
    return 0;
}
