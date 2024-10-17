#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n = 5;
    double temp, res = -1;
    while(n != 0)
    {
        cin >> temp;
        if(temp > 0)
            res = temp;
        n--;
    }
    cout << res;
}