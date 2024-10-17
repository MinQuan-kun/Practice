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
    vector<int> v;
    int temp;

    for (int i = 0; i < n; i++) {
        cin >> temp;
        if (SHT(temp)) {
            v.push_back(temp);
        }
    }

    if (v.empty()) {
        cout << 0; 
    } else {
        int Min = *min_element(v.begin(), v.end());
        cout << Min;
    }
    
    return 0;
}