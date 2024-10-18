#include <iostream>
using namespace std;
int main ()
{
    int A;
    cin >> A;
    if (A > 999){
        A /= 1000;
        cout << A % 10;
    }
    else
        cout << "-1";
    return 0;
}