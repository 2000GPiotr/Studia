#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

int r, ri, d, R, x, y;
int n;
int res;

bool on_crust(int x, int y, int rp)
{
    float dist = sqrt(x*x + y*y);
    return (R + rp <= dist) && (r - rp >=dist);
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);
    cin >> r >> d;
    cin >> n;

    R = r - d;

    for(int i=0; i<n; i++)
    {
        cin >> x >> y >> ri;
        if(on_crust(x, y, ri))
            res++;
    }
    cout << res << '\n';

    return 0;
}