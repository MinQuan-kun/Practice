#include <iostream>
#include <iomanip>
#include <math.h>
using namespace std;

int main ()
{
    int n;
    cin >> n;
    
    if (n<0) 
        cout <<-1;
    double tong =0;
    for (int i=1; i<=n; i++)
        tong += double(1.00/i);
    cout <<roundf(tong * 100)/ 100;
    return 0;
}
