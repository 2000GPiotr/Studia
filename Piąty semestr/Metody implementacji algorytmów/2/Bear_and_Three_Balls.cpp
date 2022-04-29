# include <bits/stdc++.h>
#include <vector>

using namespace std;

int main()
{
    int n;
    cin >> n;

    vector<int> tab;
    for(int i=0; i<n; i++)
    {
        int tmp;
        cin >> tmp;
        tab.push_back(tmp);
    }

    sort(tab.begin(), tab.end());

    tab.erase(unique(tab.begin(), tab.end()), tab.end());

    for(int i=2; i<tab.size(); i++)
    {
        if(tab[i]-tab[i-2] == 2)
        {
            cout << "YES" << '\n';
            return 0;
        }
    }

    cout << "NO";
    return 0;
}