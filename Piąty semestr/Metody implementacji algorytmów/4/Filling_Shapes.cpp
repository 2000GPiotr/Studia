# include <bits/stdc++.h>
#include <cmath>

using namespace std;


int main()
{
    long long int n;
    cin >> n;

    if(n<2 || n%2!=0)
    {
        cout << 0 <<'\n';
        return 0;
    }
    cout << (long long int)pow(2, n/2) <<  '\n';

    return 0;
}