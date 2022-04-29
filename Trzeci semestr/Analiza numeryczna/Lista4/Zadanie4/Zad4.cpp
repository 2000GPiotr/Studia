#include<iostream>
#include<cmath>

using namespace std;

double f(double x)
{
    return x*x - 2.0*cos(3.0*x + 1.0);
}

double bis(double a, double b, double e)
{
    double m = (a+b)/2;

    if(abs(b-a)<=e)
    {
        return m;
    }        
    else if(f(m) * f(a) < 0)
    {
        return bis(a, m, e);
    }    
    else
    {
        return bis(m, b, e);
    }
        
}

int main()
{
    double e=1e-5;
    double w1, w2;

    w1 = bis(-1.0, -0.5, e);
    w2 = bis(0, 0.5, e);
    cout << "x1=" << w1 << " f(x1)=" << f(w1) << endl;
    cout << "x2=" << w2 << " f(x2)=" << f(w2) << endl;   

    return 0;
}