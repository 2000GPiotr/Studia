#include <bits/stdc++.h>

using namespace std;

long long int t, n, x, y;

void solve()
{
    cin >> n >> x >> y;
    
    if(n==2)
    {
        cout << x << ' ' << y << '\n';
        return;
    }

    int diff = y-x;
    int d = n-1;
    
    while (d>1 && diff%d != 0)
        d--;   
    
    int interv = diff/d;

    long long int val = y;

    while (n>0 && val>0)
    {
        cout << val << ' ';
        n--; 
        val -= interv;
    }
    
    val = y+interv;

    while (n>0)
    {
        cout << val << ' ';
        n--;
        val += interv;
    }
    cout << '\n';
    return;
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> t;

    for(int i=0; i<t; i++)
        solve();

    return 0;
}