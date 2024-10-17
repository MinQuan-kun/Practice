// Code chưa chấm trên Upcoder
#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int temp = 0, res = 1; count = 0;
    while(n != 0)
    {
        temp = n % 10;
        if(temp % 2 != 0)
        {
            res *= temp;
            count++;
        }
        n /= 10;
    }
    if(count != 0)
        Console.Write(res);
    else
        Console.Write(-1);
}