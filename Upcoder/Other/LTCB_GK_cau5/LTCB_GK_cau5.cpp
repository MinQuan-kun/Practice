#include <bits/stdc++.h>
using namespace std;
long double Dequy(long long n)
{
    if(n == 1)
        return 1.0/ pow(n,3);
    return Dequy(n - 1) + (1.0 / pow(n, 3));
}
int main()
{
    long long n;
    cin >> n;
    if(n == 1)
        cout << 1;
    else
        cout << fixed << setprecision(3) << Dequy(n);
}