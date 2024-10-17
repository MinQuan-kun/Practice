#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    double Arr[n];
    double res = 0;
    for(int i = 0; i < n; i++)
        cin >> Arr[i];
    double Min = Arr[0];
    for(int i = 1; i < n; i++)
        if(Min > Arr[i])
        {
            Min = Arr[i];
            res = i;
        }
    cout << res;
    return 0;
}