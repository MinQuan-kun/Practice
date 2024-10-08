#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a, b;
    getline(cin , a);
    getline(cin , b);
    if(a > b)
    cout << a;
    else if(b > a)
    cout << b;
    else 
    cout <<"Hai xau bang nhau";
    return 0;
}