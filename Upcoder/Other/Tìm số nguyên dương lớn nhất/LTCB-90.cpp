#include <iostream>
using namespace std;
int main()
{
    long long n;
    cin>>n;
    long long tong = 0;
    long long kq;
    for (long long i = 1; i < n ; i++){
        tong+= i;
        if (tong > n)
            break;
        kq=i;
    }
    cout << kq;
}