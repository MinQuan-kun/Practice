#include <iostream>
using namespace std;
int main(){
    int A, N;
    cin >> A;
    if(A < 17)
    {
        N = A * 7000;
        cout << N;
    }
    else
    {
        if(A < 51)
        {
            N = (A - 16) * 8500 + 16 * 7000;
            cout<<N;
        }
        else
        {
            N = (A - 50) * 100000 + 34 * 8500 + 16 * 7000;
            cout << N;
        }
    }
    
    return 0;
    
}
