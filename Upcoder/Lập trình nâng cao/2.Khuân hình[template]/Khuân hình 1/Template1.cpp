#include<iostream>
using namespace std;
struct PS{
    int tu;
    int mau;
};
istream & operator >>(istream & in, PS&n);
ostream & operator <<(ostream & out,PS n);
bool operator <(PS a, PS b);
template <typename T>
void Xuly();
int main(){
    char kt;
    cin>>kt;
    switch (kt){
        case 'a': Xuly<int>(); break;
        case 'b': Xuly<double>(); break;
        case 'c': Xuly<PS>(); break;
    }
    return 0;
}
istream & operator >>(istream & in, PS&n){
    in>>n.tu>>n.mau;
    return in;
}
ostream & operator <<(ostream & out,PS n){
    out<<n.tu<<"/"<<n.mau;
    return out;
}
template<typename T>
void Xuly(){
    T a, b ,c;
    cin>>a>>b>>c;
    T max=a;
    if(max<b)
    max=b;
    if(max<c)
    max=c;
    cout<<max;
}
bool operator <(PS a, PS b){
    return ((double) a.tu/a.mau <(double) b.tu/b.mau);
}