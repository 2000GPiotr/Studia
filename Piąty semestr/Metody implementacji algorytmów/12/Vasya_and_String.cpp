#include <bits/stdc++.h>

using namespace std;

int n, k;
string s;

typedef long long ll;

ll check(char x)
{
    
    queue <int> ind;
    int cnt = 0;
    int ans = 0;
    for(int i=0; i<s.length(); i++)
    {
        if(s[i] != x)
        {
            if(k>0)
            {
                s[i] = x;
                k--;
                ind.push(i);
                cnt++;
            }
            else
            {
                if(ind.empty())
                {
                    cnt = 0;
                }
                else
                {
                    int j = ind.front();
                    ind.pop();
                    cnt = i-j;
                    ind.push(i);
                }
                    
            }
        }
        else
        {
            cnt++;
        }
        ans = max(ans, cnt);
    }
    return ans;
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n >> k;
    cin >> s;
    string p = s;
    int pom = k;
    int a1 = check('a');
    s=p;
    k=pom;
    int a2 = check('b');

    cout << max(a1, a2) << '\n';

    return 0;
}