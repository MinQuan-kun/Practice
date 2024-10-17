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
    int n, res = 0;
    cin >> n;
    int Arr[n];
    for(int i = 0; i < n; i++)
    {
        cin >> Arr[i];
        if(CheckSNT(Arr[i]))
            res = Arr[i];
    }
    cout << res;
}