#include <iostream>
using namespace std;

int main() {
    unsigned short gio, phut, giay;
    cin >> gio >> phut >> giay;
    
    if(gio > 23 or phut > 59 or giay > 59) cout << "NO";
    else {
        cout << "YES\n";
        if(giay == 59) phut++, giay = 0;
        else giay++;
        if(phut > 59) gio++, phut = 0, giay = 0;
        if(gio > 23) gio = 0, phut = 0, giay = 0;
        cout << gio << ':' << phut << ':' << giay;
    }
    
    return 0;
}