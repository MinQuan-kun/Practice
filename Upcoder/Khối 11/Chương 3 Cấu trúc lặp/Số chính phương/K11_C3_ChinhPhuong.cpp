#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n, n1;
    cin >> n;
    if(n < 0)
        cout << "False";
    else
    {
        n1 = sqrt(n);
        if(n1 * n1 == n)
            cout << "True";
        else
            cout << "False";
    }
    return 0;
}