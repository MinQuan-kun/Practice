#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a;
    char kt;
    getline(cin, a);
    cin >> kt;
    size_t vitri = a.find(kt);
    while( vitri != string::npos)
    {
        cout << vitri << " ";
        vitri = a.find(kt, vitri + 1);
    }
    return 0;
}