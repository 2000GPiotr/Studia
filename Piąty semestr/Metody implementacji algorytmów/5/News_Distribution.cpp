#include <bits/stdc++.h>
#include <vector>
#include <queue>

using namespace std;

struct UnionFind
{
    int parent;
    int size;
};
UnionFind tab[500001];

void Init(int n)
{
    for(int i=0; i<n; i++)
    {
        tab[i].parent = i;
        tab[i].size = 1;
    }
}

int Find(int nr)
{
    if(tab[nr].parent == nr)
        return nr;
    tab[nr].parent = Find(tab[nr].parent);
    return tab[nr].parent;
}

void Union(int nr1, int nr2)
{
    nr1 = Find(nr1);
    nr2 = Find(nr2);
    if(nr1 == nr2)
        return;
    if(tab[nr1].size < tab[nr2].size)
        swap(nr1, nr2);
    tab[nr2].parent = nr1;
    tab[nr1].size += tab[nr2].size;
}

bool contains(vector<int> v, int x)
{
    return count(v.begin(), v.end(), x);
}

vector<int> used;
vector<int> touse;

int main()
{
    long long int n, m;
    cin >> n;
    cin >> m;

    vector<int> groups[m];

    
    for(int i=0; i<m; i++)
    {
        int k, x;
        cin >> k;
        for(int j=0; j<k; j++)
        {
            cin >> x;
            groups[i].push_back(x);
        }
    }

    Init(n);


    for(int i=0; i<m; i++)
    {
        for(int j=0; j<groups[i].size(); j++)
        {
            Union(groups[i][0], groups[i][j]);
        }
    }

    for(int i=1; i<=n; i++)
        cout << tab[Find(i)].size << ' ';

}
