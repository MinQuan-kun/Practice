#include <iostream>
using namespace std;

int main() {
    int a, b, c;
    while(cin >> a)
    {
        cin >> b >> c;

    // Kiểm tra tính hợp lệ của 3 cạnh
        if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a) {
            int perimeter = a + b + c;
            cout << perimeter << endl;
        } else {
            cout << "NO" << endl;
        }
    }
    return 0;
}
