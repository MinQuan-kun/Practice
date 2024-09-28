#include<bits/stdc++.h>
using namespace std; 
bool ktscp(int);
bool ktsl(int);
int main()
{
    vector<int>:: iterator it;
    vector<int> v;
    int n;
    while(cin >> n)
    {
        v.push_back(n);
    }
    v.erase(remove_if(v.begin(), v.end(), ktscp), v.end());
    v.erase(remove_if(v.begin(), v.end(), ktsl), v.end());
    sort(v.begin(), v.end());
    for(it = v.begin(); it != v.end(); it++)
        cout << *it << " ";
    return 0;
}
bool ktscp(int a)
{
    if (sqrt(a) == (int)sqrt(a))
    return true;
    return false;
}
bool ktsl(int a)
{
    if(a % 2 != 0)
    return true;
    else
    return false;
}