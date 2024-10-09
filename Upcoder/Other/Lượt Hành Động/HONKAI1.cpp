#include<bits/stdc++.h>
using namespace std;
struct NV
{
    string name;
    int speed;
};
istream & operator >>(istream & in, NV & n)
{
    in>> n.name>>n.speed;
    return in;
}
ostream & operator <<(ostream & out, NV n)
{
    out<<n.name;
    return out;
}
bool operator >(NV a, NV b)
{
    return(a.speed>b.speed);
}
int main(){
    int n;
    cin>>n;
    vector<NV> v;
    NV a;
    while(n--){
        cin>>a;
        v.push_back(a);
    }
    sort(v.begin(), v.end(), greater<NV>());
    for (NV c : v)
        cout << c << endl;
    return 0;
}
    
   
