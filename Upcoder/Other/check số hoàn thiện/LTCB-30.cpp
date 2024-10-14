#include<bits/stdc++.h>
using namespace std;
bool SHT(int x) {
    if (x <= 1) 
        return false; 
    int tong = 0;
    for (int i = 1; i <= x / 2; i++) {
        if (x % i == 0) {
            tong += i;
        }
    }
    return tong == x; 
}
int main() {
    int n;
    cin >> n;
    if(SHT(n))
        cout << "YES";
    else
        cout << "NO";
    return 0;
}