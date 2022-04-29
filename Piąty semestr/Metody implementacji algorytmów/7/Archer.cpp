#include <bits/stdc++.h>

using namespace std;

double a, b, c, d;
double pre, res;

int main()
{
    cin >> a >> b >> c >> d;
    double p1 = a/b;
    double p2 = c/d;

    double tmp = 1;

    for (int i = 1;;i++)
    {
        res += tmp * p1;
        
        if (i > 1 && abs(pre-res) < (1e-9) ) 
            break;
        
        tmp *= (1-p1)*(1-p2);
        pre = res;
    }
    
    cout << res << '\n';

    return 0;
}