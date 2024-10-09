#include <bits/stdc++.h>
using namespace std;

long double Dequy(long long n)
{
    long double result = 1.0 / 2.0 + 3.0 / 4.0;
    for (int i = 2; i <= n; ++i) {
        result += (2 * i + 1.0) / (2 * i + 2.0);  
    }
    return result;
}

int main()
{
    long long n;
    cin >> n;
    if(n == 0)
        cout << 1.0 / 2.0;
    else
        cout << Dequy(n); 
    return 0;
}
