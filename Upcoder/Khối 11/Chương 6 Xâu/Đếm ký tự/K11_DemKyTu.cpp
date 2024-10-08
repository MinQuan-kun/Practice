#include<bits/stdc++.h>
using namespace std;
int main()
{
    char kt;
    string a;
    getline(cin, a);
    cin >> kt;
    int dem = 0;
    for( char c :a)
    if(c == kt) 
        dem++;
    cout << dem;
    return 0;
}