#include<bits/stdc++.h>
using namespace std;
bool checkSNT(int n)
{
    if(n <  2)
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
    if(n < 2)
        cout << -1;
    else
    {
        for(int i = 2; i <= n; i++)
            if(checkSNT(i))
            {
                if(i != n)
                    cout << i << " ";
                else
                    cout << i;
            }
                
    }
    return 0;
}