#include <bits/stdc++.h>
using namespace std;

int main() {
    int N;
    cin >> N;

    int arr[50];
    for (int i = 0; i < N; i++)
        cin >> arr[i];

    int count = 1; 
    for (int i = 1; i < N; i++)
        if (arr[i] >= arr[i - 1]) 
            count++;
    cout << count;
    return 0;
}
