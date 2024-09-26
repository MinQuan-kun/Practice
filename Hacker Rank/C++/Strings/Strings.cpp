#include <iostream>
#include <string>
using namespace std;

int main() {
	string a,b;
    cin >> a>> b;
    int len = a.size();
    int len2 = b.size();
    string c = a + b;
    cout << len << " " << len2 << endl << c << endl;
    char k = a[0];
    a[0] = b[0];
    b[0] = k;
    cout << a <<" " << b;
    
    
    return 0;
}