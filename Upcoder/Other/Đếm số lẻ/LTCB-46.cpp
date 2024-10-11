#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int temp, count = 0;
    while(n != 0)
    {
        temp = n % 10;
        if(temp % 2 != 0)
            count += 1;
        n /= 10;
    }
    cout << count;
}