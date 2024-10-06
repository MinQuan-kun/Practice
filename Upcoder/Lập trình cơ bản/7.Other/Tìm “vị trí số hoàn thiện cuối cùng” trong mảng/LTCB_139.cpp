#include <iostream>
using namespace std;

bool PerfectNumber(long long num) {
    if (num < 2) return false;

    long long sum = 0;
    for (long long i = 1; i <= num / 2; i++) {
        if (num % i == 0) {
            sum += i;
        }
    }

    return sum == num;
}

int FindLast(long long array[], int n) {
    int lastIndex = -1;
    for (int i = 0; i < n; i++) {
        if (PerfectNumber(array[i])) {
            lastIndex = i;
        }
    }
    return lastIndex;
}

int main() {
    int n;
    cin >> n;

    long long array[n];
    for (int i = 0; i < n; i++) {
        cin >> array[i];
    }

    int result = FindLast(array, n);
    cout << result << endl;

    return 0;
}
