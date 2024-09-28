#include<bits/stdc++.h>
using namespace std;
struct BacNhat
{
    int a;
    int b;
};
istream & operator >> (istream & in, BacNhat & n)
 {
    in >> n.a >> n.b;
    return in;
}
ostream & operator << (ostream & out, BacNhat n)
{
    if(n.b == 0)
    out << n.a << "x";
    else if(n.b > 0)
    out << n.a << "x" << "+" << n.b;
    else
    out << n.a << "x" << n.b;
    return out;
}
bool operator == (BacNhat a, BacNhat b)
{
    return (a.a + a.b == b.a + b.b);
}
bool operator != (BacNhat a, BacNhat b)
{
    return (a.a + a.b != b.a + b.b);
}
BacNhat operator + (BacNhat a, BacNhat b)
{
    BacNhat c;
    c.a = a.a + b.a;
    c.b = a.b + b.b;
    return c;
}
int main()
{
    int x;
    BacNhat a, b,c;
    cin >> a >> b;
    cin >> x;
    c = a + b;
    cout << a << endl << b << endl;
    cout << a << "+" << b << "=" << c << endl;
    cout << a.a * x + a.b <<endl;
    cout << b.a * x + b.b <<endl;
    if(a == b)
    cout << "TRUE";
    else
    cout << "FALSE";
}