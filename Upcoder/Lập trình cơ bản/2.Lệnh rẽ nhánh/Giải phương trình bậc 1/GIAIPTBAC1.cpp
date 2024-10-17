#include<bits/stdc++.h>
using namespace std;
int main()
{
    int a, b;
    cin >> a >> b;
    if(a == 0)
    {
        if(b == 0)
            cout<<"VSN";
        else
            cout << "VN";
    }
    else
    {
        float x = (float)-b / a;
        cout << fixed << setprecision(2) << x;
    }
    return 0;
}