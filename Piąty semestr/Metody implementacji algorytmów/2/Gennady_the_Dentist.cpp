#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

#define N 4010

int n;
ll v[N], d[N], p[N];
bool l[N];
vector<int> ans;

void run(int i)
{
    for(int j=i+1; j<=n; j++)
    {
        if(p[j]>=0)
        {
            p[j] -= d[i];
        }            
    }
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> n;

    for(int i=1; i<=n; i++) 
        cin >> v[i] >> d[i] >> p[i];
    
    for(int i=1; i<=n; i++)
    {        
        if(p[i] >= 0)
        {
            ans.push_back(i);

            for(int j = i+1; j<=n; j++)
            {
                if(p[j]>=0)
                {
                    p[j] -= v[i];
                    v[i]--;
                }
                
                if (v[i] <= 0)
                    break;                      
            }  
            for(int j=i+1; j<=n; j++)
            {
                if(p[j]<0)
                {
                    if(l[j] == 0)
                    {
                        l[j] = 1;
                        run(j);
                    }                 
                }
            }      
        }
    }

    cout << ans.size() << '\n';
    for(int i=0; i<ans.size(); i++)
        cout << ans[i] << ' ';

    return 0;
}