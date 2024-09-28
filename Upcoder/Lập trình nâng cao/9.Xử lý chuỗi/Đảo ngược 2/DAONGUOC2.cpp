#include<bits/stdc++.h>
using namespace std;
int main(){
    ifstream inFile("inDaoNguoc2.txt");
    ofstream outFile("outDaoNguoc2.txt");
    vector<string> v1;
    string a;
    while(inFile >> a){
        reverse(a.begin(), a.end());
        v1.push_back(a);
    }
    vector<int> v2;
    for(int i = 0; i < v1.size(); i++){
        int num = stoi(v1[i]);
        v2.push_back(num);
    }
    int max = v2[0];
    for(int i = 1; i < v2.size(); i++){
        if(max < v2[i])
            max = v2[i];
    }
    string res = to_string(max);
    reverse(res.begin(), res.end());
    outFile << res << endl; // Ghi ra số đảo ngược lớn nhất vào file outDaoNguoc2.txt
    int check=0;
    for(int i = 0; i < v2.size(); i++){
        if(v2[i] == max)
        check++;
    }
    if(check == 1)
    return 0;
    // Tìm các vị trí của số đảo ngược lớn nhất trong dãy số
    vector<int> positions;
    for(int i = 0; i < v2.size(); i++){
        if(v2[i] == max)
            positions.push_back(i);
    }
    // Nếu có vị trí thì ghi vào file
    if(!positions.empty()){
        for(int i = 0; i < positions.size(); i++){
            outFile << positions[i] << " ";
        }
        outFile << endl;
    }
    return 0;
}