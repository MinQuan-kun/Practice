#include <bits/stdc++.h>
using namespace std;
int main()
{
    double S, E, T;
    double gia = 30000;
    double gia2 = 30000 * 0.7;
    while (cin >> S)
    {
        cin >> E;
        T = E - S;
        if(T <= 3)
        {
            T = T * 30000;
            cout << T << endl;
        }
        else
        {
            T = 3 * 30000 + (T - 3) * (30000 * 0.7);
            cout << T << endl;
        }
    }
    return 0;
}