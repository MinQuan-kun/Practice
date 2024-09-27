#include<bits/stdc++.h>
using namespace std;

int main()
{
    int VN1, VN2, VN3, TL1, TL2, TL3;
    int numchoice = 0;
    cin >> VN1 >> VN2 >> VN3 >> TL1 >> TL2 >> TL3;
    cin >> numchoice;

    int sumVN = VN1 + VN2 + VN3;
    int sumTL = TL1 + TL2 + TL3;

    if(numchoice == 1)
    {
        if(sumVN > sumTL)
            cout << "VN";
        else if(sumVN < sumTL)
            cout << "TL";
        else 
            cout << "TIE"; 
    }
    else if(numchoice == 2)
    {
        if(sumVN != sumTL)
        {
            if(VN1 != TL1)
            {
                if(VN1 > TL1)
                    cout << "VN";
                else
                    cout << "TL";
            }
            else if(VN2 != TL2)
            {
                if(VN2 > TL2)
                    cout << "VN";
                else
                    cout << "TL";
            }
            else
            {
                if(VN3 > TL3)
                    cout << "VN";
                else
                    cout << "TL";
            }
        }
        else
            cout << "TIE";
    }
    
    return 0;
}
