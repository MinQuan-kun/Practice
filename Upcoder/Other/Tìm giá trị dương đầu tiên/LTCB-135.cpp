#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    double temp, res = -1;
    while(n != 0)
    {
        cin >> temp;
        if(temp > 0)
        {
            res = temp;
            break;
        }
            
        n--;
    }
    cout << res;
    return 0;
}