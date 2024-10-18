#include <bits/stdc++.h>
using namespace std;
int main () 
{
    int d, m, y;
    cin >> d >> m >> y;
    if((y >= 1900) && ((y % 400 == 0) || (y % 4 == 0)) && (y % 100 != 0) && m == 2 && d <= 29)
        cout << "YES";
    else  if((y >= 1900) && ((y % 400 != 0) || (y % 4 == 0)) && (y % 100!= 0)&& m==2 && d<=28)
        cout << "YES";
    else if((y >= 1900) && (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && d <= 31)
        cout << "YES";
    else if((y >= 1900) && (m == 4 || m == 6 || m == 9 || m == 11) && d <= 30)
        cout<<"YES";
    else 
        cout<<"NO";
    return 0;
}