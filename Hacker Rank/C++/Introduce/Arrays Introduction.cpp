#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
   int n;
   cin >> n;
   int Arr[n];
    for(int i = 0; i < n ; i++)
        cin>>Arr[i];
    for(int j = n - 1 ; j >= 0 ; j--)
        cout << Arr[j] <<" ";
   return 0;
}
