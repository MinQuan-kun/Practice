#include <bits/stdc++.h>
using namespace std;

int main() {
    int a, b, c;
    while(cin >> a)
    {
        cin >> b >> c;
    // Kiểm tra tính hợp lệ của 3 cạnh
        if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a) {
            double p = (a + b + c) / 2.0;
            double S = sqrt(p * (p - a) * (p - b) * (p - c));
            int perimeter = a + b + c;
            cout << perimeter << " ";
            cout << fixed << setprecision(0) << S << endl;
        } else {
            cout << "Khong phai tam giac" << endl;
        }
    }
    return 0;
}
