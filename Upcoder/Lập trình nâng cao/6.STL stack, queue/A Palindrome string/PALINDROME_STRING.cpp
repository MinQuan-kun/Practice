#include<bits/stdc++.h>
#include <cctype>
using namespace std;
bool isPalindrome(string s) 
{
    stack<char> charStack;
    for (char c : s) {
        if (isalnum(c)) 
            charStack.push(tolower(c));
    }
    for (char c : s) 
    {
        if (isalnum(c)) 
        {
            if (tolower(c) != charStack.top()) 
                return false;
            charStack.pop();
        }
    }
    return true;
}

int main() 
{
    string s;
    getline(cin, s);
    if (isPalindrome(s))
        cout << "YES" << endl;
    else
        cout << "NO" << endl;
    return 0;
}
