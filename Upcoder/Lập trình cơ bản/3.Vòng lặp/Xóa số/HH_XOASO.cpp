#include <bits/stdc++.h>
using namespace std;

int main() {
    string N;
    cin >> N;  

    string maxNumber = "";  

    for (int i = 0; i < N.length(); i++) {
        string temp = N.substr(0, i) + N.substr(i + 1);

        if (maxNumber == "" || temp > maxNumber) {
            maxNumber = temp;
        }
    }
    if(N.length() == 1)
        cout << N;
    else
        cout << maxNumber;

    return 0;
}
