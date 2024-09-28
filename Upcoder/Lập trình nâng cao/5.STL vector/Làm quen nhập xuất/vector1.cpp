#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    vector<int> v;
    while(cin >> n)
        v.push_back(n);
    for (auto it = v.begin(); it != v.end(); ++it)
        cout << *it << " ";
    cout << endl;
    for (auto rit = v.rbegin(); rit != v.rend(); ++rit)
        cout << *rit << " ";
    cout << endl;
    return 0;
}