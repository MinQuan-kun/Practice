#include <bits/stdc++.h>
using namespace std;
int main() {
    int a;
    cin >> a;
    int temp = 0;
    while(a != 0)
    {
        temp = temp * 10 + a % 10;
        a /= 10;
    }
    cout << temp;
    return 0;
}