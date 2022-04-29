#include<iostream>
#include<cmath>

using namespace std;

double f(double x)
{
    return -((2*x*x*x) + sqrt(x*x*x*x + 2020)) / ((sqrt(x*x*x*x + 2020)) * (sqrt(x*x*x*x + 2020)));
}

int main()
{
    for(double i=56; i<60; i+=0.001)
    {
        cout << i << " : " << f(i) << endl;
    }
    return 0;
}