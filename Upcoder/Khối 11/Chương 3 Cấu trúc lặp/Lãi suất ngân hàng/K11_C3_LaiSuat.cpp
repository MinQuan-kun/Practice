#include <bits/stdc++.h>
using namespace std;
int main()
{
    float x, n, tien;
    cin >> x >> n;
    if(x < 0 || n < 0)
        cout << 0;
    else
    {
        tien = 0;
        float temp = x;
        for(int i = n + 1; i <= 12; i++)
        {
            tien = x + (temp * 0.05);
            temp = x + temp * 0.05;
        }
        cout << tien;    
    }
    return 0;
}