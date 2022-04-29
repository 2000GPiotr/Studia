#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    int l, r, x, y, k;
    float d;

    cin >> l >> r >> x >> y >> k;

    for(int a=l; a<=r; a++)
    {
        for(int b=x; b<=y; b++)
        {
            d = a/b;
            if(d == k)
            {
                cout << "YES";
                return 0;
            }
        }
    }

    cout << "NO";

    return 0;
}