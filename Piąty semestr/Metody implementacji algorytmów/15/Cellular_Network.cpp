#include <bits/stdc++.h>
#include <limits>

using namespace std;

typedef long long ll;

int n, m;
vector<ll> cities;
vector<ll> towers; 
ll p, ans;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n >> m;
    for(int i=0; i<n; i++)
    {
        cin >> p;
        cities.push_back(p);
    }

    for(int i=0; i<m; i++)
    {
        cin >> p;
        towers.push_back(p);
    }
    
    int j=0;
    for(int i=0; i<n; i++) 
    {
        for(j; j<m; j++)
        {
            if (abs(cities[i] - towers[j]) < abs(cities[i] - towers[j+1]))
                break;
        }
        ans = max(ans, abs(cities[i] - towers[j]));
    }

    cout << ans <<'\n';
        

    return 0;
}