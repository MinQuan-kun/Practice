#include<bits/stdc++.h>
using namespace std;
int main()
{
    char kt;
    int max = 0;
    while(true)
    {
        cin >> kt;
        if(max < (int)kt)
            max = (int)kt;
        if(kt == '0')
            break;
    }
    cout << (char)max;
}