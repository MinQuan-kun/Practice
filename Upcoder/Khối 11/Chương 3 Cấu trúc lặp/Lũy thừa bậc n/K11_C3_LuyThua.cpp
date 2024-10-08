#include<bits/stdc++.h>
using namespace std;
int main()
{
    int x, n;
    cin >> x >> n;
    if(n < 0)
    {
        cout << 1;
        return 0;
    }
    if(n == 0)
    {
        cout << 1;
        return 0;
    }
    int s = x;
    for(int i = 1; i < n; i++)
    {
        s *= x;
    }
    cout << s;
    return 0;
}