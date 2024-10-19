#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    while(cin >> n)
    {
        int tong = 0;
        while(n != 0)
        {
            tong += n % 10;
            n /= 10;
        }
        cout << tong << endl;
    }
    return 0;
}