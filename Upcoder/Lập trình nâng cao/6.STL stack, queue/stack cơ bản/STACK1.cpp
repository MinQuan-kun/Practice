#include <iostream>
#include <stack>
using namespace std;
void xuly(stack<char> & n)
{
    char nd;
    while (cin >> nd)
    {
        if (nd == '*')
        {
            if (!n.empty()) 
            {
                cout << n.top() << endl;
                n.pop();
            }
        }else 
            n.push(nd);
    }
    cout << endl;
}
int main()
{
    stack<char> noidung;
    xuly(noidung);
    return 0;
}