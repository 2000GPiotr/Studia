#include <bits/stdc++.h>

using namespace std;

const int N = 10009;
int n, c;
int res;
vector<int> tree[N];
int colour[N];

void dfs(int v, int c)
{
    int cl = c;
    if(c != colour[v])
    {
        res++;
        cl = colour[v];
    }
    for(int i=0; i<tree[v].size(); i++)
    {
        int w = tree[v][i];
        dfs(w, cl);
    }
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);
    cin >> n;
    
    for(int i=2; i<=n; i++)
    {
        int p;
        cin >> p;
        tree[p].push_back(i);
    }

    for(int i=1; i<=n; i++)
    {
        cin >> c;
        colour[i] = c;
    }

    dfs(1, 0);

    cout << res << '\n';

    return 0;
}