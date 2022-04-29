#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios :: sync_with_stdio(0);
    cin.tie(0);

    int m;
    long long d, l;
    vector<pair<long long ,long long>> sznurki;

    cin >> m;

    for(int i=0; i<m; i++)
    {
        cin >> d >> l;

        while (d%2 == 0)
        {
            d /= 2;
            l *= 2;
        }
        sznurki.push_back({d,l});        
    }
    sort(sznurki.begin(), sznurki.end());
    
    d=0; l=0;
    
    int suma = 0;

    sznurki.push_back({-1,0});

    for(auto i : sznurki)
    {
        if(d != i.first)
        {
            suma += __builtin_popcountll(l);
            d = i.first;
            l = 0;
        }
        l += i.second;        
    }

    cout << suma <<'\n';
    
    return 0;
}