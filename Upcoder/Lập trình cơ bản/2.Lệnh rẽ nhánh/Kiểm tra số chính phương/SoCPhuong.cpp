#include<bits/stdc++.h>
using namespace std;
int main()
{
    int a;
    cin >> a;
    string temp = "";
    for(int i = 0; i < a; i++)
        if(i * i == a)
            temp = "true";
    if(temp == "true")
        cout << "yes";
    else
        cout << "no";
}