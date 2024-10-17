#include <iostream>
using namespace std;
int main ()
{
    int AB, BC, CA, n;
    do
    cin >> AB >> BC >> CA >> n;
    while(AB < 0 && BC < 0 && CA < 0 && n < 0);
    int S1 = AB + BC + CA;
    while(n > S1)
    n = n - S1;
    if(n == AB){
        cout << "B";
        return 0;
    }
    if(n < AB){
        cout << "AB";
        return 0;
    }
    if(n == (AB + BC)){
        cout << "C";
        return 0;
    }
    if(n < (AB + BC)){
        cout << "BC";
        return 0;
    }
    if(n < (AB + BC + CA)){
        cout << "CA";
        return 0;
    }
    if(n == (AB + BC + CA)){
        cout << "A";
        return 0;
    }
        return 0;
}