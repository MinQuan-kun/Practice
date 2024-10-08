#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n, tong = 0;
    cin >> n;
    for(int i = 1; i <= n; i++)
        if(i % 5 == 0)
            tong = tong + i;
    cout << tong;
    return 0;
}
