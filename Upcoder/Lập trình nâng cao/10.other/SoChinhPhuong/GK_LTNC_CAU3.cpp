#include<bits/stdc++.h>
using namespace std;

// Hàm kiểm tra xem một số có phải là số chính phương hay không
bool isPerfectSquare(int num) {
    int root = static_cast<int>(sqrt(num));
    return root * root == num;
}

// Hàm loại bỏ các số chính phương từ một dãy số
vector<int> removePerfectSquares(const vector<int>& arr) {
    vector<int> result;
    for (int num : arr) {
        if (!isPerfectSquare(num)) {
            result.push_back(num);
        }
    }
    return result;
}

int main() {
    // Đọc số lượng phần tử cho 2 dãy
    int n, m;
    cin >> n >> m;

    vector<int> array1(n);
    vector<int> array2(m);

    // Đọc dãy số thứ nhất
    for (int i = 0; i < n; ++i) {
        cin >> array1[i];
    }

    // Đọc dãy số thứ hai
    for (int i = 0; i < m; ++i) {
        cin >> array2[i];
    }

    // Loại bỏ các số chính phương
    vector<int> filtered1 = removePerfectSquares(array1);
    vector<int> filtered2 = removePerfectSquares(array2);

    // Tạo hội
    vector<int> unionVector = filtered1; // Bắt đầu với filtered1

    // Thêm filtered2 vào unionVector
    unionVector.insert(unionVector.end(), filtered2.begin(), filtered2.end());

    // Tạo giao (cho phép trùng lặp)
    vector<int> intersection;
    for (int num : filtered1) {
        // Đếm số lần xuất hiện trong filtered2
        int numCount = count(filtered2.begin(), filtered2.end(), num); // Đổi tên biến
        for (int i = 0; i < numCount; ++i) {
            intersection.push_back(num);
        }
    }

    // Sắp xếp hội
    sort(unionVector.begin(), unionVector.end());

    // Sắp xếp giao
    sort(intersection.begin(), intersection.end());

    // In ra kết quả
    for (int num : unionVector) {
        cout << num << " ";
    }
    cout << endl;

    for (int num : intersection) {
        cout << num << " ";
    }
    return 0;
}
