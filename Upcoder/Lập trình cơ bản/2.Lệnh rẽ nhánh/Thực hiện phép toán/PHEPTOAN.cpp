#include<bits/stdc++.h>
using namespace std;
int main()
{
    int a, b, tong;
    cin >> a >> b;
    string var;
    cin >> var;
    if(var == "+")
        tong = a + b;
    if(var == "-")
        tong = a - b;
    if(var == "%")
        tong = a % b;
    if(var == "*")
        tong = a * b;
    cout << a << var << b << "=" << tong;
    return 0;
}