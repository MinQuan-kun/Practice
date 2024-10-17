#include <bits/stdc++.h>
using namespace std;
int main(){
    int n, c = 0;
    cin >> n;
    for (int i = n; i != 0; i/=10)
    {
        c++;
    }
    cout << c;
}