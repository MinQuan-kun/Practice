#include<iostream>
#include<math.h>
using namespace std;
int main(){
    int n;
    int k ;
    cin >> n;
    for(int i =2;i<=sqrt((float)n);i++){
        if(n%i==0)
        k =1;
    }
    if(k ==1 or n<=1) cout << "false";
    else if(k!=1)  cout << "true";
    return 0;
}