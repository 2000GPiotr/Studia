#include <iostream>

using namespace std;
double t[96];
double x[96] = {5.5, 8.5, 10.5, 13, 17, 20.5, 24.5, 28, 32.5, 37.5, 40.5, 42.5, 45, 47,
             49.5, 50.5, 51, 51.5, 52.5, 53, 52.8, 52, 51.5, 53, 54, 55, 56,
             55.5, 54.5, 54, 55, 57, 58.5, 59, 61.5, 62.5, 63.5, 63, 61.5,
             59, 55, 53.5, 52.5, 50.5, 49.5, 50, 51, 50.5, 49, 47.5, 46, 45.5, 45.5,
             45.5, 46, 47.5, 47.5, 46, 43, 41, 41.5, 41.5, 41, 39.5, 37.5, 34.5,
             31.5, 28, 24, 21, 18.5, 17.5, 16.5, 15, 13, 10, 8, 6, 6, 6, 5.5,
             3.5, 1, 0, 0, 0.5, 1.5, 3.5, 5, 5, 4.5, 4.5, 5.5, 6.5, 6.5, 5.5};
double y[96] = {41, 40.5, 40, 40.5, 41.5, 41.5, 42, 42.5, 43.5, 45, 47, 49.5, 53, 57, 59,
             59.5, 61.5, 63, 64, 64.5, 63, 61.5, 60.5, 61, 62, 63, 62.5, 61.5, 60.5,
             60, 59.5, 59, 58.5, 57.5, 55.5, 54, 53, 51.5, 50, 50, 50.5, 51, 50.5,
             47.5, 44, 40.5, 36, 30.5, 28, 25.5, 21.5, 18, 14.5, 10.5, 7.50, 4,
             2.50, 1.50, 2, 3.50, 7, 12.5, 17.5, 22.5, 25, 25, 25, 25.5, 26.5,
             27.5, 27.5, 26.5, 23.5, 21, 19, 17, 14.5, 11.5, 8, 4, 1, 0, 0.5, 3,
             6.50, 10, 13, 16.5, 20.5, 25.5, 29, 33, 35, 36.5, 39, 41};

double h = 1.0/95.0;
double lambda = 0.5;
double dx[96];
double qx[96];
double ux[96];
double px[96];
double mx[96];

double dy[96];
double qy[96];
double my[96];
double uy[96];
double py[96];

double wynikix[96];
double wynikiy[96];

void ilrozx()
{
    for(int i=1; i<95; i++)
    {
        dx[i] = (((x[i+1]-x[i])/(t[i+1] - t[i])) - ((x[i]-x[i-1])/(t[i] - t[i-1]))) / (t[i+1] - t[i-1]);
    }    
}

void pomocx()
{
    qx[0]=0;
    ux[0]=0;

    for(int i=1; i<96; i++)
    {
        px[i] = lambda * qx[i-1] + 2;
        qx[i] = (lambda - 1)/px[i];
        ux[i] = (dx[i] - lambda*ux[i-1])/px[i];
    }
}

void mkix()
{
    mx[95] = 0;
    mx[0] = 0;
    mx[94] = ux[94];
    for(int i=93; i>0; i--)
    {
        mx[i] = ux[i] + qx[i]*mx[i+1];
    }
}

//--------------------------------------------------------------------------------------------------------------------------------------

void ilrozy()
{
    for(int i=1; i<95; i++)
    {
        dy[i] = (((y[i+1]-y[i])/(t[i+1] - t[i])) - ((y[i]-y[i-1])/(t[i] - t[i-1]))) / (t[i+1] - t[i-1]);
    }    
}

void pomocy()
{
    qy[0]=0;
    uy[0]=0;

    for(int i=1; i<96; i++)
    {
        py[i] = lambda * qy[i-1] + 2;
        qy[i] = (lambda - 1)/py[i];
        uy[i] = (dy[i] - lambda*uy[i-1])/py[i];
    }
}

void mkiy()
{
    my[95] = 0;
    my[0] = 0;
    my[94] = uy[94];
    for(int i=93; i>0; i--)
    {
        my[i] = ux[i] + qx[i]*my[i+1];
    }
}

double wartoscx(double o)
{
    int k=0;
    for(int i=0; i<95; i++)
    {
        if((t[i] <= o) && (o <= t[i+1]))
        {
            k=i;
            break;
        }            
    }


    double a = (1.0/6.0) * mx[k-1] * (t[k]-o) * (t[k]-o)* (t[k]-o);
    double b = (1.0/6.0) * mx[k] * (o-t[k-1]) * (o-t[k-1]) * (o-t[k-1]);
    double c = (x[k-1] - ((1.0/6.0) * mx[k-1]*h*h)) * (t[k] + o);
    double d = (x[k] - ((1.0/6.0) * mx[k]*h*h)) * (o - t[k-1]);

    return (1.0/h) * (a+b+c+d);
}

double wartoscy(double o)
{
    int k=0;
    for(int i=0; i<95; i++)
    {
        if((t[i] <= o) && (o <= t[i+1]))
        {
            k=i;
            break;
        }            
    }


    double a = (1.0/6.0) * my[k-1] * (t[k]-o) * (t[k]-o)* (t[k]-o);
    double b = (1.0/6.0) * my[k] * (o-t[k-1]) * (o-t[k-1]) * (o-t[k-1]);
    double c = (y[k-1] - ((1.0/6.0) * my[k-1]*h*h)) * (t[k] + o);
    double d = (y[k] - ((1.0/6.0) * my[k]*h*h)) * (o - t[k-1]);

    return (1.0/h) * (a+b+c+d);
}

int main()
{
    /*for(int i=0; i<96; i++)
    {
        cout << x[i] << ' ' << y[i] << endl;
    }*/
    for(int i=0; i<96; i++)
    {
        t[i] = i/95;
    }

    ilrozx();
    pomocx();
    mkix();

    ilrozy();
    pomocy();
    mkiy();

    for(int i=1; i<96; i++)
    {
        wynikix[i] = wartoscx(t[i]);
        wynikiy[i] = wartoscy(t[i]);
    }

    for(int i=0; i<96; i++)
    {
        cout << wynikix[i] << ' ' << wynikiy[i] << endl;
    }

    return 0;
}