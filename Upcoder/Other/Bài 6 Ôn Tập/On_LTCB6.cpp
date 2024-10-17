#include<bits/stdc++.h>
using namespace std;

struct P {
    int x, y;
};

struct C {
    P t;
    int r;
};

double d(P a, P b) {
    return sqrt(pow(a.x - b.x, 2) + pow(a.y - b.y, 2));
}

bool ck(C c1, C c2) {
    double dis = d(c1.t, c2.t);
    int sumR = c1.r + c2.r;
    int diffR = abs(c1.r - c2.r);
    return (dis < sumR && dis > diffR);
}

int main() {
    int n, cnt = 0;
    cin >> n;
    C c[50];
    for (int i = 0; i < n; i++)
        cin >> c[i].t.x >> c[i].t.y >> c[i].r;
    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            if (ck(c[i], c[j])) cnt++;
        }
    }
    cout << cnt << endl;
    return 0;
}
