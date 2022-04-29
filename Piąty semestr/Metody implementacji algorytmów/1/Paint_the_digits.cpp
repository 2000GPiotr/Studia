// #include <bits/stdc++.h>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int t=0;

void solve()
{
    string s="", sorted="";
    int n=0;
    int p=0;

    cin >> n;
    cin >> s;
    sorted = s;
    sort(sorted.begin(), sorted.end());

    bool paint[n]={};

    for(int i=0; i<n; i++)
    {
        if(sorted[p]==s[i])
        {
            paint[i] = true;
            p++;
        }
    }

    string s1="", s2="";

    for(int i=0; i<n; i++)
    {
        paint[i] ? s1+=s[i] : s2+=s[i];
    }
   // cout << s1 << ' ' << s2 << '\n' << sorted << '\n';
    if(s1+s2 == sorted)
    {
        for(int i=0; i<n; i++)
        {
            if(paint[i])
                cout << 1;
            else
                cout << 2;
        }
        cout << '\n';
        return;
    }
    cout << '-' << '\n';
    return;
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> t;

    for(int i=0; i<t; i++)
        solve();

    return 0;
}