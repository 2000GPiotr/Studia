#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    int m, n;
    int l, r, x;

    cin >> n >> m;

    set<int> alive;
    for (int i = 1; i <= n; i++)
        alive.insert(i);

    int ans[n+1];
    for(int i=0; i<=n; i++)
        ans[i] = 0;

    for(int i=0; i<m; i++)
    {
        cin >> l >> r >> x;

        set<int>::iterator it = alive.lower_bound(l);

         while(*it <= r && it != alive.end())
        {
            if(*it != x)
            {
                ans[*it] = x;
                int p = *it;
                it++;
                alive.erase(p);
            }
            else
                it++;
        }
    }

    for(int i=1; i<=n; i++)
        cout << ans[i] << ' ';
        
    return 0;
}