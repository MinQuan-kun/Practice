#include<bits/stdc++.h>
using namespace std;
bool CheckSNT(int n)
{
    if(n < 2)
        return false;
    for(int i = 2; i * i <= n; i++)
        if(n % i == 0)
            return false;
    return true;
}
int main()
{
    int n;
    cin >> n;
    for(int i = 2; i < n; i++)
        if(CheckSNT(i))
            cout << i << " ";
    return 0;
}