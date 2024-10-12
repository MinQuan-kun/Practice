#include <bits/stdc++.h>
using namespace std;

int main() {
    int a, b, c;
    cin >> a >> b >> c;

    int Max = max(a, max(b, c));
    int Min = min(a, min(b, c));

    int medium = a;
    if ((b > Min && b < Max) || (b > Max && b < Min))
        medium = b;
    if ((c > Min && c < Max) || (c > Max && c < Min))
        medium = c;

    if (medium % 2 == 0)
        cout << medium << " la so chan";
    else
        cout << medium << " la so le";

    return 0;
}
