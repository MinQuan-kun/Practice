#include <bits/stdc++.h>
using namespace std;
int main()
{
    int x, tien = 2500;
    cin >> x;
    if(x < 0)
        cout << "NHAP SAI";
    else
    {
        if(x <= 50)
            tien *= x;
        else if(x >= 51 && x <= 100)
            tien = tien * 50 + (x - 50) * 3000;
        else if(x >= 101 && x <= 200)
            tien = tien * 50 + 3000 * 50 + (x - 100) * 5000;
        else if(x > 200)
            tien = -1;
        if(tien == -1)
            cout << "CAT DIEN";
        else
            cout << tien;
    }
    return 0;
}