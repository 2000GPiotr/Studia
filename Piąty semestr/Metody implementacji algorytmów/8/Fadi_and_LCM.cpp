#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

ll x;

ll gcd(ll l1, ll l2)
{
    if(l2 == 0)
        return l1;
    return gcd(l2, l1 % l2);
}

void solution(ll x)
{
    ll s = sqrt(x);
    for(int i=s; i>0; i--)
    {
        if(x % i == 0)
        {
            ll p = x/i;
            if(gcd(p, i)==1)
            {
                cout << p << ' ' << i << '\n';
                return;
            }
                
        }
    }
}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0);

    cin >> x;

    solution(x);

    return 0;
}