#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    if(n < 0)
        cout << "AM";
    else if(n == 0)
        cout << "KHONG";
    else
        cout << "DUONG";
    return 0;
}