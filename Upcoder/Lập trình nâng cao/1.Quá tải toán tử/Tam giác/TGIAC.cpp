#include<bits/stdc++.h>
using namespace std;
struct TD
{
  int x, y;
  double doDai(TD other) 
    {
        return sqrt(pow(other.x - x, 2) + pow(other.y - y, 2));
    }
};
istream & operator >> (istream & in, TD & a)
{
    in >> a.x >> a.y;
    return in;
}
ostream & operator << (ostream & out, TD a)
{
    out << "(" << a.x << "," << a.y << ")";
    return out;
}
bool operator == (TD a, TD b)
{
    return (a.x == b.x and a.y == b.y);
}

struct Tamgiac
{
    TD a, b ,c;
    double CV() {
        return a.doDai(b) + b.doDai(c) + c.doDai(a);
    }
};
istream & operator >> (istream & in, Tamgiac & a)
{
    in >> a.a >> a.b >> a.c;
    return in;
}
ostream & operator << (ostream & out, Tamgiac a)
{
    out << a.a << a.b << a.c;
    return out;
}

string operator <(Tamgiac a, Tamgiac b)
{
    if(a.CV() < b.CV())
    return "TRUE";
    else
    return "FALSE";
}
string operator == (Tamgiac a, Tamgiac b)
{
    if(a.CV() == b.CV())
    return "TRUE";
    else
    return "FALSE";
}
int main()
{
    Tamgiac a, b;
    cin >> a >> b;
    cout << a << endl << b << endl;
    cout << (a < b) << endl;
    cout<< (a == b);
}