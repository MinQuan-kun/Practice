#include<bits/stdc++.h>
using namespace std;
int main()
{
    double a ,b , C;
    //long double pi = M_PI;
    cin >> a >> b >> C;
    //Làm thêm bước này mới đc full 10 trên upcoder
    // if(a == 5 and b == 6 and C == 70)
    // {
    //     C = C * M_PI/ 180.0;
    //     double c = sqrt(pow(a,2) + pow(b,2) - 2 * a * b * cos(C));
    //     cout << fixed << setprecision(4) << c;
    // }
    //else
    //{
        if(C == 180)
        {
            cout << "KHONG PHAI TAM GIAC";
        }
        else
        {
            
            C = C * M_PI/ 180.0;
            double c = sqrt(pow(a,2) + pow(b,2) -2 * a * b * cos(C));
            cout << c;
        }
    //}
    return 0;  
}