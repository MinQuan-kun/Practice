#include<bits/stdc++.h>
using namespace std;
bool CheckSNT(int n)
{
    if(n < 2)
        return false;
    for(int i = 2; i * i <= n; i++)
        if(n % i == 0)
            return false;
    return true;
}
int main()
{
    int n;
    vector<int> v;
    while(cin >> n)
    {
        int tong = 0;
        if(n < 2)
            cout << "NO" << endl;
        else
        {
            for(int i = 2; i <= n ; i++)
            {
                if(CheckSNT(i))
                {
                    tong +=i;
                    v.push_back(i);
                }
            }
            cout << "Tong cac so nguyen to <= " << n << " la:" << endl; 
            for(int i = 0; i < v.size() - 1; i++)
                cout << v[i] <<" + ";
            cout << v[v.size() - 1] <<" = " << tong << endl;
        }
    }
    return 0;
}