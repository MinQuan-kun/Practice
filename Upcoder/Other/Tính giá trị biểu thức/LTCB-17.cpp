#include <bits/stdc++.h>
using namespace std;
int Fib(int n)
{
    if(n == 1)
        return 1;
    return n*Fib(n - 1 );
}
double DequyS(int n, double x)
{
    if(n == 1)
        return x;
    return DequyS(n - 1, x) + (pow(x, n) / Fib(n));
}
int main()
{
    int n;
    double x;
    cin >> n >> x;
    cout << DequyS(n, x);
    return 0;
}