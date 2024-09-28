#include <iostream>
#include <queue>
using namespace std;
void xuly(queue<char>& n) 
{
    char nd;
    while (cin >> nd) 
    {
        if (nd == '*') 
        {
            if (!n.empty()) 
            {
                cout << n.front() << endl;
                n.pop();
            }
        } else 
        {
            n.push(nd);
        }
    }
    cout << endl;
}
int main() 
{
    queue<char> noidung;
    xuly(noidung);
    return 0;
}