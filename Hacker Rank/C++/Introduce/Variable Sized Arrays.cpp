#include <iostream>
#include <vector>
using namespace std;

int main() {
    int n, q;
    cin >> n >> q; 

    vector<vector<int>> arrays(n); 
    for (int i = 0; i < n; i++) {
        int k;
        cin >> k; 
        arrays[i].resize(k); 
        for (int j = 0; j < k; j++) {
            cin >> arrays[i][j]; 
        }
    }

  
    for (int i = 0; i < q; i++) {
        int x, y;
        cin >> x >> y; 
        cout << arrays[x][y] << endl; 
    }

    return 0;
}
