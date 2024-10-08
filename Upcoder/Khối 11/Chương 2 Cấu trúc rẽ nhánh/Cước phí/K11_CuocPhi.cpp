#include <bits/stdc++.h>
using namespace std;
int main()
{
    double x, tien = 3000;
    cin >> x;
    if (x < 0)
    {
        cout << "NHAP SAI";
    }
    else
    {
        if( x - (int)x >= 0.5)
            x = (int)x + 1;
        else
            x = (int)x;
        if(x == 0)
            tien = 0;
        else if(x == 1)
            tien = tien;
        else if(x >= 2 and x <= 10)
            tien = tien + (x - 1) * 2000;
        else if(x >= 11)
            tien = tien + 9 * 2000 + (x - 10) * 1500;
        cout << tien;
    }
    return 0;
}