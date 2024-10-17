#include<bits/stdc++.h>
using namespace std;
double Dequy(double x, int n)
{
    if(n == 1)
        return x;
    return Dequy(x, n - 1) + pow(x, n);
}
int main()
{
    double x;
    int n;
    cin >> x >> n;
    cout << Dequy(x, n);
}