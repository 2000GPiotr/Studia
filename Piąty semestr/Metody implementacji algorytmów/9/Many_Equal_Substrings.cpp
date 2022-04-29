#include <bits/stdc++.h>

using namespace std;

string s;

int n, t, k;

int main()
{    
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n >> t;
    cin >> s;
    
    for(int i=0; i<n-1; i++) 
        if(s.substr(0, i+1) == s.substr(n-i-1)) 
            k=i+1;
    
    cout << s;
    
    for(int i=1; i<t; i++) 
        cout << s.substr(k);

    return 0;
}