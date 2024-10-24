#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    double temp = 1;
    double S = 1;
    for(int j = 0; j <= n; j++)
    {
        temp *= (2.0*(j + 1)) / (2.0 * j + 3);
        S+= temp;
    }
        cout << fixed << setprecision(2) << S << endl;
}