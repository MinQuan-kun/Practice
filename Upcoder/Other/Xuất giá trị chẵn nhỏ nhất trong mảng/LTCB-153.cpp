#include<bits/stdc++.h>
using namespace std;

int main() {
    int n;
    cin >> n;
    vector<int> arr(n);
  
    for (int i = 0; i < n; i++)
        cin >> arr[i];

    int minEven = INT_MAX;  
    bool found = false;      

    for (int i = 0; i < n; i++) 
    {
        if (arr[i] % 2 == 0) 
        { 
            found = true;
            minEven = min(minEven, arr[i]);
        }
    }

    cout << (found ? minEven : -1);
    return 0;
}
