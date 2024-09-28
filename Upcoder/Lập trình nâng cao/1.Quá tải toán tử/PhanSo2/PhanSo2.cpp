#include<iostream>
using namespace std;
struct PS
{
    int tu, mau;
};
struct MPS
{
    int size;
    PS a[100];
    PS & operator[](int i)
    {
        return a[i];
    }
};
int UCLN(int a, int b);
PS rutgon(PS a);
istream & operator >> (istream & in, PS & n);
ostream & operator << (ostream & out, PS n);
istream & operator >> (istream & in, MPS & n);
ostream & operator << (ostream & out, MPS n);
bool operator == (PS a, PS b);
bool operator != (PS a, PS b);
PS operator + (PS a, PS b);
PS tongmangPS(MPS a);
int main(){
    MPS a;
    cin >> a;
    PS c = tongmangPS(a);
    cout << c;
    return 0;
}
istream & operator >> (istream & in, PS & n){
    in >> n.tu >> n.mau;
    return in;
}
ostream & operator << (ostream & out, PS n){
    out << n.tu << "/"<< n.mau << " ";
    return out;
}
istream & operator >> (istream & in, MPS & n){
    n.size = 0;
    while(in >> n.a[n.size]){
        n.size++;
    }
    return in;
}
ostream & operator << (ostream & out, MPS n){
    for(int i = 0; i < n.size; i++)
        out << n.a[i];
    return out;
}
bool operator == (PS a, PS b){
    return (a.mau * b.tu == a.tu * b.mau);
}
bool operator != (PS a, PS b){
    return !(a == b);
}
PS operator + (PS a, PS b){
    PS c;
    c.tu = a.tu * b.mau + a.mau * b.tu;
    c.mau = a.mau * b.mau;
    return rutgon(c);
}
int UCLN(int a, int b){
    if(b == 0)
        return a;
    else
        return UCLN(b, a % b);
}
PS rutgon(PS a){
    int b = UCLN(a.tu, a.mau);
    a.tu /= b;
    a.mau /= b;
    return a;
}
PS tongmangPS(MPS n) {
    PS tong;
    tong.tu = 0;
    tong.mau = 1;
    for (int i = 0; i < n.size; i++) {
        tong = tong + n.a[i];
    }
    tong = rutgon(tong);
    return tong;
}