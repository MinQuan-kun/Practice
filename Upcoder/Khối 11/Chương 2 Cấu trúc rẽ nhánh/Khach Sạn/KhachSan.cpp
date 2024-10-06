#include <iostream>

using namespace std;

int main() {
    int arrival, departure;
    cin >> arrival >> departure;

    if (arrival < 1 || arrival > 7 || departure < 1 || departure > 7) {
        cout << "NHAP SAI";
        return 0;
    }

    int totalNights = 0;
    if (departure >= arrival) {
        totalNights = departure - arrival;
    } else {
        totalNights = (7 - arrival) + departure; 
    }

    int totalCost = 0;
    for (int i = 0; i < totalNights; i++) {
        int currentDay = (arrival + i - 1) % 7 + 1;
        if (currentDay == 1) {
            totalCost += 400000;
        } else {
            totalCost += 300000;
        }
    }

    cout << totalCost;
    return 0;
}
