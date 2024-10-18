#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    if(n % 3 == 0)
        cout <<"{0} chia het cho 3";
    if(n % 3 == 2)
        cout <<"{0} chia 3 du 2";
    if(n % 3 == 1)
        cout <<"{0} chia 3 du 1";
    return 0;
}