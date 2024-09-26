#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <cassert>
using namespace std;

class Student {
private:
    vector<int> scores; // To hold the student's exam scores

public:
    // Method to input the student's scores
    void input() {
        scores.clear(); // Clear previous scores if any
        int score;
        for (int i = 0; i < 5; i++) { // Assume there are always 5 scores
            cin >> score;
            scores.push_back(score); // Store each score
        }
    }

    // Method to calculate the total score
    int calculateTotalScore() {
        int total = 0;
        for (int score : scores) {
            total += score; // Sum the scores
        }
        return total; // Return the total score
    }
};

int main() {
    int n; // number of students
    cin >> n;
    Student *s = new Student[n]; // an array of n students
    
    for(int i = 0; i < n; i++){
        s[i].input();
    }

    // calculate kristen's score
    int kristen_score = s[0].calculateTotalScore();

    // determine how many students scored higher than kristen
    int count = 0; 
    for(int i = 1; i < n; i++){
        int total = s[i].calculateTotalScore();
        if(total > kristen_score){
            count++;
        }
    }

    // print result
    cout << count;
    
    return 0;
}
