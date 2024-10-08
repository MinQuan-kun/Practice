#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a;
    getline(cin, a);
    int n, m;
    cin >> n >> m;
    if( n < 0 || m >= a.size()) 
        cout<<"gioi han khong dung";
    else 
        cout << a.substr(n, m - n + 1);
    return 0;
}