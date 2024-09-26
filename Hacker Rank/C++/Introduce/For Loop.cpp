#include <iostream>
#include <cstdio>
using namespace std;

int main() {
    int n;
    string Arr[] = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    int k;
    cin >> n >> k;
    for(int i = n; i <=k;i++)
        if(i >= 1 && i <= 9)
            cout << Arr[i] << endl;
        else if(i % 2 == 0)
            cout <<"even" << endl;
        else 
            cout<<"odd" << endl;
    return 0;
}
