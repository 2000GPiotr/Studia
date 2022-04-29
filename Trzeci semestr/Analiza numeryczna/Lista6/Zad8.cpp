#include<iostream>
#include<cmath>

using namespace std;

long long int f(int x)
{
    return (2020 * pow(x,5)) + (1977 * pow(x,4)) - (1410 * pow(x,3)) + (1945 * x) - 1791;
}

int main()
{
    cout << f(-1) << endl << f(0) << endl <<f(1);

    return 0;
}