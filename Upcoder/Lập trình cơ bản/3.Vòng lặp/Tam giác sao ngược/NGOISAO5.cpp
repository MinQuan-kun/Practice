#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int cnt = 1;
    
    int sao = n * 2 - 1;
    int temp = 2;
    for (int i = 1; i <= n; i++)
    {
        for(int j = 1;j < cnt; j++)
            cout <<" ";
        if(i != n)
        {
            for(int e = 0; e < sao; e++)
                cout <<"*";
            for(int j = 1;j < cnt; j++)
                cout <<" ";
            cout << endl;
        }
        else
        {
            cout << "*";
            for(int j = 0;j < n - 1; j++)
                cout <<" ";
        }
            
        sao -= 2; 
        cnt++;
    }
    return 0;
}