#include <bits/stdc++.h>
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
    int temp;
    int count = 0;
    while(n != 0)
    {
        cin >> temp;
        if(CheckSNT(temp) and temp < 100)
            count ++;
        n--;
    }
    cout << count;
}