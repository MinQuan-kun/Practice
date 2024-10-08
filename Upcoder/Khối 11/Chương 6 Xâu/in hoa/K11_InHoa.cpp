#include <iostream>
using namespace std;
int main() 
{
    string a;
    while(cin>>a)
    {
        for(int i=0;i<a.size(); i++)
            if(islower(a[i]))
                a[i]= toupper(a[i]);
        cout<<a<<" ";
    }
    return 0;
}
