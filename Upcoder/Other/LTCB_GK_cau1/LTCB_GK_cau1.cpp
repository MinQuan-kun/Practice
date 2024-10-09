#include<bits/stdc++.h>
using namespace std;
int main()
{
    int a, b;
    char c;
    cin >> a >> c >> b;
    switch(c)
    {
        case '+': 
            cout << a << "+" << b << "=" << a + b;
            break;
        case '-': 
            cout << a << "-" << b << "=" << a - b;
            break;
        default: return 0;
    }
    return 0;
}