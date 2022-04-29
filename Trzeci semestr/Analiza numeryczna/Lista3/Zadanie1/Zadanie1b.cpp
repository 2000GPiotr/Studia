#include<iostream>
#include<cmath>

# define PI 3.1415926535897932384626433832795028841971693993751058209749445923

using namespace std;

double f(double x)
{
    return (atan(x) - x)/(x*x*x);
}

double bf(double x)
{
    return -1.0/3.0 + (x*x)/5 - (x*x*x*x)/7 + (x*x*x*x*x*x)/9;
}

int main()
{
    cout << f(0.00000001) << endl;
    cout << bf(0.00000001) << endl;
    return 0;
}