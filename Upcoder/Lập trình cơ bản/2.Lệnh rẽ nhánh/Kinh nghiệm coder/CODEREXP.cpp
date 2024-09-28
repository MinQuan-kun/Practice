#include <bits/stdc++.h>
using namespace std;

int main() 
{
    int Basic, Medium, Extra, Hard;
    cin >> Basic >> Medium >> Extra >> Hard;
    int Point = Basic * 10 + Medium * 20 + Extra * 30 + Hard * 40;
    cout << Point << endl;
    if (Point >= 7000)
        cout << "Coder Giao Su";
    else if (Point >= 5500)
        cout << "Coder Tien Si";
    else if (Point >= 4200)
        cout << "Coder Thac Si";
    else if (Point >= 3500)
        cout << "Coder Dai Hoc";
    else if (Point >= 2500)
        cout << "Coder Cao Dang";
    else if (Point >= 2000)
        cout << "Coder Trung Cap";
    else if (Point >= 1500)
        cout << "Coder THPT";
    else if (Point >= 1000)
        cout << "Coder THCS";
    else if (Point >= 500)
        cout << "Coder Tieu Hoc";
    else if (Point >= 100)
        cout << "Coder Lop La";
    else if (Point >= 50)
        cout << "Coder Lop Choi";
    else if (Point >= 1)
        cout << "Coder Lop Mam";
    else
        cout << "Coder So Sinh";
    return 0;
}
