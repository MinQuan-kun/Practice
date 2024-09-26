#include<iostream>
using namespace std;
struct PS{
    int tu,mau;
};
istream & operator >>(istream & in, PS&n);
ostream & operator <<(ostream & out,PS n);
bool operator ==(PS a, PS b);
template <typename T>
void Xuly();
int main(){
    char kt;
    cin>>kt;
    switch(kt){
    case 'a': Xuly<int>(); break;
    case 'b': Xuly<double>(); break;
    case 'c': Xuly<PS>(); break;
    }
    return 0;
}
    //Dinh nghia//
istream & operator >>(istream & in, PS&n){
    in>>n.tu>>n.mau;
    return in;
}
ostream & operator <<(ostream & out,PS n){
    out<<n.tu<<"/"<<n.mau;
    return out;
}
bool operator ==(PS a, PS b){
    return (a.tu / b.mau==a.mau / b.tu);
}
template <typename T>
void Xuly(){
    T a ,b;
    cin>>a>>b;
    if(a==b)
    cout<<"true";
    else
    cout<<"false";
}