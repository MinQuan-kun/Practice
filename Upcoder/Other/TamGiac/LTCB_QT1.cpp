#include<bits/stdc++.h>
using namespace std;
int main()
{
    long long ss;
    long long _Ngay = 0, _Gio = 0, _Phut = 0, _Giay = 0;
    cin >> ss;
    if(ss < 60)
    {
        _Giay = ss;
        cout << _Ngay << ":" << _Gio << ":" << _Phut << ":" << _Giay;
    }
    if(ss < 3600 && ss >= 60)
    {
        _Phut = ss / 60;
        _Giay = ss - _Phut * 60;
        cout << _Ngay << ":" << _Gio << ":" << _Phut << ":" << _Giay;
    }
    if(ss < 86400 && ss >= 3600)
    {
        _Gio = ss / 3600;
        ss -= _Gio * 3600;
        _Phut = ss / 60;
        _Giay = ss - _Phut * 60;
        cout << _Ngay << ":" << _Gio << ":" << _Phut << ":" << _Giay;
    }
    if(ss >= 86400)
    {
        _Ngay = ss / 86400;
        ss -= _Ngay * 86400;
         _Gio = ss / 3600;
        ss -= _Gio * 3600;
        _Phut = ss / 60;
        _Giay = ss - _Phut * 60;
        cout << _Ngay << ":" << _Gio << ":" << _Phut << ":" << _Giay;
    }
    return 0;   
}