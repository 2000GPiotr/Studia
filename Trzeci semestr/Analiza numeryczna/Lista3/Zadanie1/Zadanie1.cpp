#include<iostream>
#include<cmath>

# define PI 3.1415926535897932384626433832795028841971693993751058209749445923

using namespace std;

double f(double x)
{
    return 4 * cos(x) * cos(x) - 3.0;
}

double bf(double x)
{
    return cos(3*x)/cos(x);
}

int main()
{
    cout << f(PI/6) << endl;
    cout << bf(PI/6) << endl;
    return 0;
}