#include<iostream>
using namespace std;
struct PS
{
    int tu, mau;
};
istream & operator >>(istream & in, PS&n);
ostream & operator <<(ostream &out, PS n);
PS operator + (PS a, PS b);
bool operator == (PS a, PS b);
bool operator != (PS a, PS b);
int UCLN(int a, int b);
PS rutgon(PS a);
int main(){
    PS a,b,c;
    cin >> a >> b;
    c = a + b;
    cout << rutgon(c);
}
//Dinh nghia//
istream & operator >> (istream & in, PS & n)
{
    in >> n.tu >> n.mau;
    return in;
}
ostream & operator << (ostream &out, PS n)
{
    out << n.tu << "/" << n.mau;
    return out;
}
int UCLN(int a, int b)
{
    if(b == 0)
    return a;
    else
    return UCLN(b, a % b);
}
PS rutgon(PS a)
{
    int b = UCLN(a.tu, a.mau);
    a.tu /= b;
    a.mau /= b;
    return a;
}
bool operator == (PS a, PS b)
{
    return (a.tu * b.mau == b.tu * a.mau);
}
bool operator != (PS a, PS b){
    return (a != b);
}
PS operator + (PS a ,PS b)
{
    PS c;
    c.tu = a.tu * b.mau + a.mau * b.tu;
    c.mau = a.mau * b.mau;
    return c;
}