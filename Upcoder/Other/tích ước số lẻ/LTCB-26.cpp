#include<bits/stdc++.h>
using namespace std;
long long Sum(long long n)
{
    long long S = 1;
    for(long long i = 1; i <= n; i++)
        if(n % i == 0 && i % 2 != 0)
            S *= i;
    return S;
}
int main()
{
    long long n;
    cin >> n;
    cout << Sum(n);
}