#include<iostream>
#include<cmath>

using namespace std;

int main()
{
    double q = 1000000, r = 0.0000001;

    double c = cbrt(r+sqrt(q*q*q + r*r));

    double x = cbrt(r + sqrt(q*q*q + r*r)) + cbrt(r - sqrt(q*q*q + r*r));
    double x2 = 2*r / ((c*c + ((1/c) * (1/c)) *q*q) + q);

    cout << "x: " << x << endl;
    cout << "x2: " << x2 << endl;

    return 0;
}