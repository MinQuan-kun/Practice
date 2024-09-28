#include<iostream>
using namespace std;
// Cấu trúc biểu diễn phân số //
struct PS
{
    int tu;
    int mau;
};
// Cấu trúc biểu diễn số phức //
struct SP
{
    int a;
    int b;
};
// Hàm tìm ước chung lớn nhất //
int UCLN(int a, int b);
// Hàm rút gọn phân số//
void rutgon(PS & a);
// Quá tải toán tử nhập phân số//
istream & operator >> (istream & in, PS & n);
//Quá tải toán tử xuất phân số//
ostream & operator << (ostream & out, PS n);
//Quá tải toán tử nhập số phức//
istream & operator >> (istream & in, SP & n);
//Quá tải toán tử xuất số phức//
ostream & operator << (ostream & out, SP n);
// Khuôn mẫu hàm //
template<typename T>
void xuly(SP b);
//Tính tổng số nguyên với phân số//
SP operator + (SP a,int n);
//Tính tổng số phức với số phức//
SP operator + (SP a,SP b);
//Tính tổng số phức với phân số//
SP operator + (SP a,PS b);
//Hàm main//
int main()
{
    SP b;
    cin >> b;
    cout << b << endl;
    char kt;
    cin >> kt;
    switch (kt)
    {
        case 'i': xuly<int>(b); break;
        case 'z': xuly<SP>(b); break;
        case 'p': xuly<PS>(b); break;
    }
    return 0;
}
istream & operator >> (istream & in, PS & n)
{
    in >> n.tu >> n.mau;
     rutgon(n);
     if(n.mau < 0)
     {
        n.tu *= -1;
        n.mau *= -1;
    }
   
    return in;
}
ostream & operator << (ostream & out, PS n)
{
    rutgon(n);
    if(n.mau < 0 )
    {
        n.tu *= -1;
        n.mau *= -1;
    }
    
    out << n.tu<< "/" << n.mau;
    return out;
}
istream & operator >> (istream & in, SP & n)
{
    in >> n.a >> n.b;
    return in;
}
ostream & operator << (ostream & out, SP n)
{
    if(n.a == 0 and n.b != 1 and n.b != -1 and n.b != 0)
    {
    out << n.b << "i";
    return out;
    }
    if(n.b > 1 and n.a != 0)
    {
    out << n.a << "+" << n.b << "i";
    return out;
    }
    if(n.b == 1 and n.a != 0)
    {
    out << n.a << "+" << "i";
    return out;
    }
    if(n.b == -1 and n.a != 0)
    {
    out << n.a << "-" << "i";
    return out;
    }
    if(n.b == 1 and n.a == 0)
    {
    out << "i";
    return out;
    }
    if(n.b == -1 and n.a == 0)
    {
    out<< "-" << "i";
    return out;
    }    
    if(n.b == 0)
    {
    out << n.a;
    return out;
    }
    cout << n.a << n.b << "i";
    return out;
}
template<typename T>
void xuly(SP b)
{
    T a;
    cin >> a;
    cout << a << endl;
    cout << b + a;
}
SP operator + (SP a, int n)
{
    SP b;
    b.a = a.a + n;
    b.b = a.b;
    return b;
}
SP operator +(SP a,SP b)
{
    SP c;
    c.a = a.a + b.a;
    c.b = a.b + b.b;
    return c;
}
SP operator +(SP a,PS b)
{
   SP c;
   c.a = a.a + b.tu;
   c.b = a.b + b.mau;
   return c;
}
int UCLN(int a, int b)
{
    if(b == 0)
    return a;
    else
    return UCLN(b, a % b);
}
void rutgon(PS &a)
{
    int b = UCLN(a.tu, a.mau);
    a.mau /= b;
    a.tu /= b;
}