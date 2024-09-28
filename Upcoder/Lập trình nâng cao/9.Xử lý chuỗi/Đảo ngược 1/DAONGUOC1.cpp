#include <iostream>
#include <algorithm>
#include <sstream>
using namespace std;
int main() 
{
    int n = 0;
    string a[100];
    while (cin >> a[n]) 
    {
        reverse(a[n].begin(), a[n].end());
        n++;
    }

    stringstream SS;
    int maximum = 0;
    for (int i = 0; i < n; i++) 
    {
        SS << a[i];
        int temp;
        SS >> temp;
        if (maximum < temp) 
            maximum = temp;
        SS.clear();
    }
    string S2;
    SS << maximum;
    SS >> S2;
    reverse(S2.begin(), S2.end());
    cout << S2;
    return 0;
}
