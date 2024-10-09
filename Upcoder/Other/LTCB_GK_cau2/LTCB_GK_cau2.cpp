#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    if(n % 3 == 0)
        cout << n << " chia het cho 3";
    if(n % 3 == 2)
        cout << n << " chia 3 du " << n % 3;
    if(n % 3 == 1)
        cout << n << " chia 3 du " << n % 3;
}