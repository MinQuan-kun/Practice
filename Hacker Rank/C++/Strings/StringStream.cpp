#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str) {
    stringstream ss(str);
    vector<int> integers; 
    int number;
    while (ss >> number) {
        integers.push_back(number); 
        if (ss.peek() == ',') { 
            ss.ignore();
        }
    }
    
    return integers; 
}

int main() {
    string str;
    cin >> str;
    vector<int> integers = parseInts(str);
    for(int i = 0; i < integers.size(); i++) {
        cout << integers[i] << "\n";
    }
    
    return 0;
}