#include <bits/stdc++.h>

using namespace std;

int z, j, r, t;
string s;

void solve()
{
    cin >> s;

    z = count(s.begin(), s.end(), '0');
    j = count(s.begin(), s.end(), '1');

    r = min(z, j);

    if((r%2))
        cout << "DA" << '\n';
    else
        cout << "NET" << '\n';
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> t;

    for(int i=0; i<t; i++)
        solve();

    return 0;
}