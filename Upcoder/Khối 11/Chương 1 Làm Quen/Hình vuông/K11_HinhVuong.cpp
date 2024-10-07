#include<bits/stdc++.h>
using namespace std;
int main()
{
    double x;
    cin >> x;
    if(x < 0)
    {
        cout << "NHAP SAI";
        return 0;
    }
    else
        cout << sqrt(x);
}