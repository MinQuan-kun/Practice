#include<bits/stdc++.h>
using namespace std;
bool SHH(int n)
{
    int tong = 0;
    for(int i = 1; i < n; i++)
        if(n % i == 0)
            tong+= i;
    if(tong == n)
        return true;
    return false;
}
int main()
{
    int n;
    cin >> n;
    if(SHH(n))
        cout << "Yes";
    else
        cout << "No";
    return 0;
}