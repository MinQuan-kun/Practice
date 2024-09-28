#include <iostream>
#include <stack>
using namespace std;
stack<char> s;
bool ngoacMo(char x);
char lay();
bool trung(char x, char y);
int main(){
    char x=' ';
    while (cin>>x){
        if (ngoacMo(x)) 
            s.push(x);
        else  
            if (!trung(lay(),x)) {
                cout<<"no";
                return 0;
            }
    }
    cout<<(s.empty()?"yes":"no");
    return 0;
}
bool ngoacMo(char x){
    if (x=='('||x=='['||x=='{') 
        return true;
    return false;
}
char lay(){
    char c=' ';
    if (!s.empty()){
        c=s.top();
        s.pop();
    }
    return c;
}
bool trung(char x, char y){
    if (y==')') 
        y='(';
    else 
        if (y==']') 
            y='[';
        else 
            y='{';
    return x==y;
}