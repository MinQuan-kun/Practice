#include<bits/stdc++.h>
using namespace std;

int main() {
    string input;
    cin >> input;
    
    string result = "";
    int count = 1;     
    
    for (int i = 1; i <= input.length(); i++) {
        if (i < input.length() && input[i] == input[i - 1]) {
            count++; 
        } else {
           
            if (count > 1) {
                result += to_string(count) + input[i - 1];
            } else {
                
                result += "1" + string(1, input[i - 1]);
            }
            count = 1; 
        }
    }
    
    cout << result;
    return 0;
}
