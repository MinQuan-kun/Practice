#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int temp, res = 0;
    while(n != 0)
    {
        cin >> temp;
        if(temp % 2 == 0)
            res = temp;
        n--;
    }
    if(res != 0)
        cout << res;
    else
        cout << -1;
}