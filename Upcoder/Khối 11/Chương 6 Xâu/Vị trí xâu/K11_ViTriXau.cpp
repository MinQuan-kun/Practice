#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a, b;
    getline(cin, a);
    getline(cin, b);
    size_t vitri = a.find(b);
    while(vitri != string::npos){
        cout<< vitri;
        return 0;
    }
    cout<< "0";
    
}