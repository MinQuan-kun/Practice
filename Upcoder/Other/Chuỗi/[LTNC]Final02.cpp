#include<bits/stdc++.h>

using namespace std;

// Hàm để tách chuỗi dựa vào ký tự phân tách
vector<string> splitString(const string& str, char delimiter) {
    vector<string> result;
    string current;

    // Duyệt từng ký tự trong chuỗi
    for (char c : str) {
        if (c == delimiter) {
            if (!current.empty()) {
                result.push_back(current); // Thêm chuỗi con vào kết quả
                current.clear(); // Xóa chuỗi hiện tại
            }
        } else {
            current += c; // Thêm ký tự vào chuỗi hiện tại
        }
    }

    // Thêm phần còn lại nếu có
    if (!current.empty()) {
        result.push_back(current);
    }

    return result;
}

// Hàm để loại bỏ các ký tự phân tách thừa
string removeExtraDelimiters(const string& str, char delimiter) {
    string cleaned;
    bool lastWasDelimiter = false;

    for (char c : str) {
        if (c == delimiter) {
            if (!lastWasDelimiter) {
                cleaned += c; // Thêm ký tự phân tách nếu trước đó không phải là ký tự phân tách
                lastWasDelimiter = true; // Đánh dấu rằng ký tự cuối cùng là ký tự phân tách
            }
        } else {
            cleaned += c; // Thêm ký tự khác
            lastWasDelimiter = false; // Đánh dấu rằng ký tự cuối cùng không phải là ký tự phân tách
        }
    }

    // Loại bỏ ký tự phân tách ở đầu và cuối chuỗi
    if (!cleaned.empty() && cleaned.front() == delimiter) {
        cleaned.erase(cleaned.begin()); // Xóa ký tự đầu tiên nếu là ký tự phân tách
    }
    if (!cleaned.empty() && cleaned.back() == delimiter) {
        cleaned.pop_back(); // Xóa ký tự cuối cùng nếu là ký tự phân tách
    }

    return cleaned;
}

int main() {
    // Đọc chuỗi ban đầu và ký tự phân tách
    string inputString;
    char delimiter;

    getline(cin, inputString);
    cin >> delimiter;

    // Loại bỏ các ký tự phân tách thừa
    string cleanedString = removeExtraDelimiters(inputString, delimiter);

    // Tách chuỗi thành các chuỗi con
    vector<string> result = splitString(cleanedString, delimiter);

    // In kết quả
    cout << result.size() << endl; // Số lượng chuỗi con
    for (const string& s : result) {
        cout << s << endl; // In từng chuỗi con
    }

    return 0;
}
