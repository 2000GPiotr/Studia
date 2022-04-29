#include<iostream>
#include<cmath>

using namespace std;

int main()
{
    double a = 0.00001, b = 20000, c = 0.001;
    double delta = b*b - 4*a*c;
    double x1, x2;

    x1 = (-b - sqrt(delta)) / (2*a);
    x2 = (-b + sqrt(delta)) / (2*a);

    cout << "x1: " << x1 << "  x2: " << x2 << endl;

    return 0; 
} 