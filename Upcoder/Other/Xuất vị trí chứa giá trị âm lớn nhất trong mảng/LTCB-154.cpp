#include<bits/stdc++.h>
using namespace std;

int main() {
    int n;
    cin >> n;
    double Arr[n];
    int pos = -1;
    for(int i = 0; i < n; i++)
        cin >> Arr[i];
    double Min = -DBL_MAX; 
    for(int i = 0; i < n; i++) {
        if (Arr[i] < 0 && (pos == -1 || Arr[i] < Min)) {
            Min = Arr[i];
            pos = i;
        }
    }

    cout << pos;
    return 0;
}
