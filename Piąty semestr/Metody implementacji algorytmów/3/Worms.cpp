# include <bits/stdc++.h>
# include <vector>

using namespace std;

int main()
{
    vector<int> tab;
    int n, m, a, q, acc=0;

    cin >> n;

    for(int i=0; i<n; i++)
    {
        cin >> a; 
        tab.push_back(acc + a);
        acc += a;
    }
    cin >> m;

    for(int i=0; i<m; i++)
    {
        cin >> q;
        int l=-1, p=tab.size(), s;

        while(p-l>1)
        {
            s = (p+l)/2;

            if(q>tab[s])
                l=s;
            else
                p=s;
        }
        cout << p + 1 << '\n';
    }
    return 0;
}