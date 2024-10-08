#include <bits/stdc++.h>
using namespace std;
double DequyS(int x, int n)
{
    if (n == 0)
        return 0;
    return 1.0 / (n * x * (n + 1)) + DequyS(x, n - 1);
}
int main()
{
    int x, n;
    cin >> x >> n;
    if(x < 0 or n < 0)
        cout << -1;
    else
        cout << fixed << setprecision(3) << DequyS(x, n);
    return 0;
}