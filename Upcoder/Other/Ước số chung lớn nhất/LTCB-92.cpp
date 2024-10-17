#include<bits/stdc++.h>
using namespace std;
long long UCLN(long long n, long long m)
{
    if(m == 0)
        return n;
    return UCLN(m, n % m);
}
int main()
{
    long long n, m;
    while(cin >> n)
    {
        cin >> m;
        cout << UCLN(n, m) << endl;
    }
}