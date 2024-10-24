#include <bits/stdc++.h>
using namespace std;

// Hàm xuất đa thức
void xuatDaThuc(double a[], int n[], int k) {
    bool first = true;
    for (int i = 0; i < k; i++) {
        if (a[i] != 0) {
            if (!first) cout << " + ";
            first = false;

            if (n[i] == 0)
                cout << a[i];
            else if (n[i] == 1) {
                if (a[i] == 1) cout << "x";
                else cout << a[i] << "x";
            } else {
                if (a[i] == 1) cout << "x^" << n[i];
                else cout << a[i] << "x^" << n[i];
            }
        }
    }
    cout << endl;
}

// Hàm tính giá trị đa thức tại x
double tinhGiaTriDaThuc(double a[], int n[], int k, double x) {
    double S = 0;
    for (int i = 0; i < k; i++) {
        S += a[i] * pow(x, n[i]);
    }
    return S;
}

// Hàm xuất đạo hàm của đa thức
void daoHamDaThuc(double a[], int n[], int k) {
    bool first = true;
    int cnt = 0;
    for(int i = 0; i < k; i++)
        if(n[i] == 0)
            cnt++;
    if(cnt == k)
        cout << 0;
    for (int i = 0; i < k; i++) {
        if (n[i] > 0 && a[i] != 0) {
            if (!first) cout << " + ";
            first = false;

            double heSoDaoHam = a[i] * n[i];
            int bacDaoHam = n[i] - 1;

            if (bacDaoHam == 0)
                cout << heSoDaoHam;
            else if (bacDaoHam == 1)
                cout << heSoDaoHam << "x";
            else
                cout << heSoDaoHam << "x^" << bacDaoHam;
        }
    }
}

int main() {
    int k;
    cin >> k;

    double a[k];
    int n[k];

    for (int i = 0; i < k; i++)
        cin >> a[i];

    for (int i = 0; i < k; i++)
        cin >> n[i];

    double x;
    cin >> x;
    if(tinhGiaTriDaThuc(a, n, k, x) == 0)
    {
        cout << 0 << endl << 0 << endl << 0;
        return 0;
    }
    xuatDaThuc(a, n, k);

    double ketQua = tinhGiaTriDaThuc(a, n, k, x);
    cout << ketQua << endl;

    daoHamDaThuc(a, n, k);

    return 0;
}