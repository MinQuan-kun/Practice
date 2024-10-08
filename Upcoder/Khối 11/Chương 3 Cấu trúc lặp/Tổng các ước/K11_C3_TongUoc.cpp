#include <bits/stdc++.h>
using namespace std;
int main()
{
    long long n, tong = 0;
    cin >> n;
    if(n < 0)
        n *= -1;
    for(int i = 1; i <= n; i++)
        if(n % i == 0)
            tong += i;
    cout << tong;
}