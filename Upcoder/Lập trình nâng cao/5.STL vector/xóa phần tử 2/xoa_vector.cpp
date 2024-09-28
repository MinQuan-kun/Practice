#include<bits/stdc++.h>
using namespace std;
int main(){
    int n;
    cin >> n;
    vector<int> v;
    int n1;
    while(n--){
        cin >> n1;
        v.push_back(n1);
    }
    cin.ignore();
    string a;
    int k;
    vector<int>v1;
    getline(cin, a);
    stringstream ss(a);
    while(ss >> k)
    v1.push_back(k);
     if (!v.empty()) {
        if (v1[0] == -1) {
            v.clear();
            cout << "empty";
        } else if (v1.size() == 1) {
            if(v1[0] >= 0 && v1[0] < v.size()){
            v.erase(v.begin() + v1[0]);
            }
            for (auto it = v.begin(); it != v.end(); it++)
                cout << *it << " ";
        } else if (v1.size() == 2 && v1[0] < v.size() && v1[1] <= v.size()) {
            v.erase(v.begin() + v1[0], v.begin() + v1[1] );
            if (v.empty())
                cout << "empty";
            else {
                for (auto it = v.begin(); it != v.end(); it++)
                    cout << *it << " ";
            }
        }
    }
    return 0;
}