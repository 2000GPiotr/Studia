#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    ll l, r, x, y, k;
    ll d;

    cin >> l >> r >> x >> y >> k;

    for(ll b=x; b<=y; b++)
    {
        d = b*k;
        if(d>=l && d<=r)
        {
            cout << "YES";
            return 0;
        }
    }

    cout << "NO";

    return 0;
}