#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int count = 0;
    int temp, res;
    while(n != 0)
    {
        temp = n % 10;
        count ++;
        if(count == 3)
            res = temp;
    }
    if(count < 3)
        cout << "-1";
    else
        cout << res;
}