#include <bits/stdc++.h>
using namespace std;
double DequyS(int n)
{
    if(n == 1)
        return 1;
    return n + DequyS(n - 1);
}
double DequyX(int x, int n)
{
    if(n == 1)
        return x;
    return DequyX(x, n - 1) + (pow(x, n))/DequyS(n);
}
int main()
{
    int x, n;
    cin >> x >> n;
    cout << DequyX(x , n);
}