#include<bits/stdc++.h>
using namespace std;
long long getsize(long long n)
{
    long long temp = n;
    long long cnt = 0;
    while(temp != 0)
    {
        temp /= 10;
        cnt ++;
    }
    return cnt;
}
bool Amstrong(int n)
{
    long long temp = n;
    long long S = 0;
    long long k = getsize(n);
    while(temp != 0)
    {
        S += pow(temp % 10, k);
        temp /=10;
    }
    if(S == n)
        return true;
    else
        return false;
}
int main()
{
    long long n, m;
    cin >> n >> m;
    long long cnt = 0;
    for(long long i = n; i <= m; i++)
    {
        if(Amstrong(i))
        {
            cout << i << " ";
            cnt ++;
        }
    }
    if(cnt == 0)
        cout << -1;
    return 0;
}

/*Bài này 10 đ, nguồn code của tynn
#include <iostream>
using namespace std;

int main() {
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int a, b, sum, num, len;
    int number[10][9];
    bool check = true;

    for (int i = 0; i < 10; i++) {
        number[i][0] = 1;
        for (int j = 1; j <= 8; j++) 
            number[i][j] = number[i][j-1]*i;
    }

    cin >> a >> b;
    for (int i = a; i <= b; i++) {
        int tmp = i;
        sum = 0, len = 0, num = i;

        while (tmp > 0) 
            len++, tmp /= 10;
        
        tmp = i;
        while (tmp > 0) {
            sum += number[tmp % 10][len];
            tmp /= 10;
            if (sum > i) {
                i -= i % 10, i += 9;
                break;
            }
        }

        if (sum == num) {
            cout << i << ' ';
            check = false;
        } 
    }

    if (check) cout << -1;
    return 0;
}
*/
