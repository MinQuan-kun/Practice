#include<bits/stdc++.h>
using namespace std;
int main()
{
    string a;
    vector<int> k;
    vector<int> v;
    int num;
    int n;
    if(getline(cin, a))
    {
        stringstream ss(a);
        while(ss >> num)
        k.push_back(num);
    }
    while(cin>>n)
        v.push_back(n);
    if (!k.empty())
    {
        if (k[0] == -1)
        {
            v.clear();
            cout << "empty";
        }else if (k.size() == 1)
        {
            if(k[0] >= 0 && k[0] < v.size())
                v.erase(v.begin() + k[0]);
            if (v.empty())
                cout << "empty";
            else 
            {
                for (auto it = v.begin(); it != v.end(); ++it)
                    cout << *it << " ";
            }
        }else if (k.size() == 2)
        {
            int start = k[0];
            int end = k[1];
            if (start >= 0 && start < v.size() && end >= 0 && end <= v.size() && start < end)
                v.erase(v.begin() + start, v.begin() + end);
            if (v.empty())
                cout << "empty";
            else{
                for (auto it = v.begin(); it != v.end(); ++it)
                    cout << *it << " ";
            }
        }
    }
    return 0;
}