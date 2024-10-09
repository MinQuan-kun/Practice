#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int a = n / 1000;
    int b = (n / 100) % 10;
    int c = (n / 10) % 10;
    int d = n % 1000 % 10;
    int max = a;
    int min = a;
    if(max < b)
        max = b;
    if(max < c)
        max = c;
    if(max < d)
        max = d;
    if(min > b)
        min = b;
    if(min > c)
        min = c;
    if(min > d)
        min = d;
    cout << max + min;
    return 0;
}