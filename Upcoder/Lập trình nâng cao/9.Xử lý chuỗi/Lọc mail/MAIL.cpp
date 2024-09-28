#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a;
    while(cin >> a)
    {
        size_t vitri = a.find("@gmail.com");
        if(vitri! = string::npos)
        cout << a << endl;
    }
    return 0;
}