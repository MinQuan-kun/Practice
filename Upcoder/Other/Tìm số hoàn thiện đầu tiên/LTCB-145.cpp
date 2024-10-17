#include<bits/stdc++.h>
using namespace std;
bool SoHoanThien(int n) {
    if (n <= 0) return false;
    int sum = 0;
    for (int i = 1; i <= n / 2; i++) {
        if (n % i == 0) sum += i;
    }
    return sum == n;
}
int main() {
    int n;
    cin >> n;
    vector<int> arr(n);
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    for (int i = 0; i < n; i++) {
        if (SoHoanThien(arr[i])) {
            cout << arr[i] << endl;
            return 0;
        }
    }
    cout << -1;
    return 0;
}
