#include <bits/stdc++.h>
using namespace std;

// Hàm kiểm tra số hoàn hảo
bool SHT(int x) {
    int tong = 0;
    for (int i = 1; i <= x / 2; i++) // Chạy đến x / 2
        if (x % i == 0)
            tong += i;
    return tong == x; // Trả về true nếu là số hoàn hảo
}

int main() {
    int n;
    cin >> n; 
    int arr[n]; 
    int temp = -1; 

    for (int i = 0; i < n; i++) {
        cin >> arr[i];
        if (SHT(arr[i])) 
            temp = i; 
    }
    if (temp == -1)
        cout << -1; 
    else
        cout << temp;
    return 0;
}
