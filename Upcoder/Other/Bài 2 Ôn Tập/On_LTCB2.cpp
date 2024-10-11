#include<bits/stdc++.h>
using namespace std;
int main()
{
    int a, b;
    int A, B;
    cin >> a >> b;
    if(a % 2 == 0)
        A = a;
    else
        A = -a;
    if(b % 2 != 0)
        B = b;
    else
        B = -b;
    cout << A * B;
}