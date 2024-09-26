#include <iostream>
#include <cmath>
#include <string>
using namespace std;
bool checkSNT(int a)
{
    if(a < 2)
        return false;
    for (int i = 2; i <= sqrt(a); i++)
        if (a % i == 0)
            return false;
    return true;
}
int main() {
    string s;
    cin >> s;  
    int tong = 0;
    for (char c : s) {
        int digit = c - '0'; 
        if (!checkSNT(digit)) {
            cout << "YESNOT";  
            return 0;
        }
        tong += digit;
    }
    if (checkSNT(tong))
        cout << "YES";
    else
        cout << "YESNOT";
    return 0;
}