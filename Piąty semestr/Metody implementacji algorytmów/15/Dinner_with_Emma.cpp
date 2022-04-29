#include <bits/stdc++.h>
#include <limits>

using namespace std;

typedef long long ll;

int n, m;
ll x, ans, pom;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n >> m;
    
    ans = 0;

    for(int i=0; i<n; i++)
    {
        pom = LONG_MAX;
        for(int j=0; j<m; j++)
        {
            cin >> x;
            if(x<pom) 
                pom = x;
        }
        if(pom>ans) 
            ans = pom;
    }

    cout << ans << '\n';

    return 0;
}