#include<bits/stdc++.h>
using namespace std;

// Hàm kiểm tra số nguyên tố
bool CheckSNT(int n) {
    if (n < 2) 
        return false;
    if (n == 2 || n == 3 || n == 5 || n == 7) 
        return true;
    return false;
}

int main() {
    long long N;
    int Q, temp;
    vector<int> v;
    cin >> N >> Q;
    while (N != 0) {
        temp = N % 10;
        v.push_back(temp);
        N /= 10;
    }

    sort(v.begin(), v.end());
    v.erase(unique(v.begin(), v.end()), v.end());

    if (Q > v.size()) {
        cout << "-1";
    } else {
        int result = v[Q - 1];
        cout << result << " "; 
        if (CheckSNT(result)) {
            cout << "Yes";
        } else {
            cout << "No";
        }
    }

    return 0;
}
