#include<bits/stdc++.h>
using namespace std;

int main()
{
    int n;
    cin >> n;
    long long temp, res = 0;
    while(n != 0)
    {
        cin >> temp;
        if(temp % 2 == 0)
        {
            cout << temp << endl;
            res++;
        }
        n--;
    }
    if(res == 0)
        cout <<-1;
    return 0;
}