#include<bits/stdc++.h>
using namespace std;

int main() {
    int n;
    cin >> n;

    if (n == 0) {
        cout << "VO SO UOC" << endl;
    } else {
        stringstream uoc; 

        for (int i = 1; i <= abs(n); i++) {
            if (n % i == 0) {
                uoc << i << " "; 
            }
        }

        string result = uoc.str();
        if (!result.empty()) {
            result.pop_back(); 
        }
        cout << result;
    }

    return 0;
}
