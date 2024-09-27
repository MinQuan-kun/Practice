#include <bits/stdc++.h>
using namespace std;

int main()
{
    int a, b, c, d;
    cin >> a >> b >> c >> d;
    if(a == b and b == c and c == d)
        cout << -1;
    else
    {
        int Max = max({a, b, c, d});
        int Min = min({a, b, c, d});
        int Max2 = Min;
        if(Max2 < a and a != Max)
            Max2 = a;
        if(Max2 < b and b != Max)
            Max2 = b;
        if(Max2 < c and c != Max)
            Max2 = c;
        if(Max2 < d and d != Max)
            Max2 = d;
        cout << Max2;
    }
    return 0;
}
