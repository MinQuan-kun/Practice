#include <iostream>
using namespace std;

int main() {
    int a, b;
    cin >> a >> b;

    bool hasResult = false;

    if (a + b >= 0) {
        cout << (a + b) << " ";
        hasResult = true;
    }

    if (a - b >= 0) {
        cout << (a - b) << " ";
        hasResult = true;
    }
    if (a * b >= 0) {
        cout << (a * b) << " ";
        hasResult = true;
    }

    if (!hasResult) {
        cout << "impossible";
    }

    return 0;
}
