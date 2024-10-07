#include<bits/stdc++.h>
using namespace std;
int main()
{
    double x;
    cin >> x;
    double tong = ((abs(2 * x + 3)/cos(x)) + sqrt(2 + cos(x)));
    cout << tong;
}