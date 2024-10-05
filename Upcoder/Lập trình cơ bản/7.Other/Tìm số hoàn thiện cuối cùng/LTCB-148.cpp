#include<bits/stdc++.h>
using namespace std;
bool SHT(int x) {
    int tong = 0;
    for (int i = 1; i <= x / 2; i++) // Chạy đến x / 2
        if (x % i == 0)
            tong += i;
    return tong == x; // Trả về true nếu là số hoàn hảo
}
int main()
{
    int arr[5];
    int temp = -1;
    for(int i = 0; i < 5; i++)
    {
        cin>> arr[i];
        if(SHT(arr[i]))
            temp = i;
    }
    if(temp == -1)
        cout << "-1";
    else
        cout << arr[temp];
}
