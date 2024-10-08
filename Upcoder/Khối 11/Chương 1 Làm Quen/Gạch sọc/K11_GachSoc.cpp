#include <bits/stdc++.h>
using namespace std;
int main()
{
    double a;
    cin >> a;
    double Shcn = a * a;
    double Shtron = M_PI * (a / 2) * (a / 2);
    cout << Shcn - Shtron;
    return 0;
}