#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

#define N 200010

int n, m, k;
int x, y;
int color [N];
vector<int> socks [N]; 
vector<int> c;
int tab[N];
int ans;
   
bool visited[N];

void my_count(int v)
{
    visited[v] = 1;
    c.push_back(color[v]);
    for(int i=0; i<socks[v].size(); i++)
    {
        if(!visited[socks[v][i]])
            my_count(socks[v][i]);
    }
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n >> m >> k;

    for(int i=1; i<=n; i++)
        cin >> color[i];

    for(int i=0; i<m; i++)
    {
        cin >> x >> y;
        socks[x].push_back(y);
        socks[y].push_back(x);
    }

    for(int i=1; i<=n; i++)
    {
        if(!visited[i])
        {
            my_count(i);
            int s = c.size();
            int maks=0;
            for(int j=0; j<s; j++)
            {
                tab[c[j]]++;                  
                if(tab[c[j]]>maks)
                    maks=tab[c[j]];
            }
            int to_color = s-maks;
            ans += to_color;
            
            for(int j=0; j<s; j++)
            {
                tab[c[j]]--;
            }
            c.clear();
        }
            
    }

    cout << ans << '\n';

    return 0;
}