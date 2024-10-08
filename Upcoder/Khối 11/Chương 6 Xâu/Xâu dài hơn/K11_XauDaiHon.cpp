#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a, b;
    getline(cin, a);
    getline(cin, b);
    if(a.size() > b.size())
    cout << a;
    else if(a.size() < b.size())
    cout << b;
    else
    cout << "Hai xau dai bang nhau";
    return 0;
}