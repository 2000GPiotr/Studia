#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

int n, t;
string q;

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);
    cin >> n >> t;
    cin >> q;

    for (int i = 0; i < t; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            if(q[j] == 'B' && q[j+1] == 'G')
            {
                swap(q[j], q[j+1]);
                j++;
            }
        }
        
    }
    
    cout << q << '\n';


    return 0;
}