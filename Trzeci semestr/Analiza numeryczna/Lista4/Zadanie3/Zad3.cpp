#include<iostream>
#include<cmath>

using namespace std;

double f(double x)
{
    return x - 0.49;
}

int main()
{
    double a = 0, b = 1, m;

    for(int i=0; i<5; i++)
    {
        m = (a + b) / 2.0;
        cout << "[" << a << ";" << b << "] " << "m=" << m << " f(m)=" << f(m) << " Blad: " << abs(0.49 - m) << " Oszacowanie: " << (1-0)/pow(2, i+1) << endl;

        if(f(m)*f(a) < 0)
        {
            b=m;
        }
        else
        {
            a=m;
        }
        
    }

    return 0;
}