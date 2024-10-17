#include <iostream>
using namespace std;
int main()
{
    long T, P, C, A4;
    cin >> T >> P >> C;
    if (T == 1)
	{
		A4 = P * C;
		cout << A4 << endl;
	}
	else if (T == 2)
    {
		if (P % 2 == 0)
		{
			A4 = P / 2 * C;
		}
		else
		{
			A4 = (P+1) / 2 * C ;     //(float)p=257/2=128.5
		}                           //p+1=258/2=129
		cout << A4 << endl;
	}
    return 0;
}
