#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int tong = 1;
    for(int i = 1; i <= n; i++)
        tong *=i;
    cout << tong;
}