#include<bits/stdc++.h>
using namespace std;

bool checksnt(int x) {
    if (x < 2) return false; 
    for (int i = 2; i <= x / 2; i++) {
        if (x % i == 0) return false; 
    }
    return true;
}
int main()
{
    int temp = -1;
    int arr[5];
    for(int i = 1; i <= 5; i++)
    {
        cin >> arr[i];
        if(checksnt(arr[i]))
            temp = i;
    }
    if(temp == -1)
        cout << -1;
    else
        cout << arr[temp];
    return 0;
}