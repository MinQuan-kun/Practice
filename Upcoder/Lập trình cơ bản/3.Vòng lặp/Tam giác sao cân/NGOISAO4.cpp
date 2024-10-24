#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int khoangtrang = n - 1;
    int sao = 1;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < khoangtrang; j++)
            cout <<" ";
        for(int e = 0; e < sao; e ++)
            cout <<"*";
        for(int f = 0; f < khoangtrang; f++)
            cout <<" ";
        if(i != n - 1)
            cout << endl;
        khoangtrang --;
        sao += 2;
    }
    return 0;
}