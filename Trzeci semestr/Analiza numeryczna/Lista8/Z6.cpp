#include <iostream>
#include <cmath>

using namespace std;

#define N 96
#define M 100000

double wartosci_x[N] = {5.5, 8.5, 10.5, 13, 17, 20.5, 24.5, 28, 32.5, 37.5, 40.5, 42.5, 45, 47,
                        49.5, 50.5, 51, 51.5, 52.5, 53, 52.8, 52, 51.5, 53, 54, 55, 56,
                        55.5, 54.5, 54, 55, 57, 58.5, 59, 61.5, 62.5, 63.5, 63, 61.5,
                        59, 55, 53.5, 52.5, 50.5, 49.5, 50, 51, 50.5, 49, 47.5, 46, 45.5, 45.5,
                        45.5, 46, 47.5, 47.5, 46, 43, 41, 41.5, 41.5, 41, 39.5, 37.5, 34.5,
                        31.5, 28, 24, 21, 18.5, 17.5, 16.5, 15, 13, 10, 8, 6, 6, 6, 5.5,
                        3.5, 1, 0, 0, 0.5, 1.5, 3.5, 5, 5, 4.5, 4.5, 5.5, 6.5, 6.5, 5.5};

double wartosci_y[N] = {41, 40.5, 40, 40.5, 41.5, 41.5, 42, 42.5, 43.5, 45, 47, 49.5, 53, 57, 59,
                        59.5, 61.5, 63, 64, 64.5, 63, 61.5, 60.5, 61, 62, 63, 62.5, 61.5, 60.5,
                        60, 59.5, 59, 58.5, 57.5, 55.5, 54, 53, 51.5, 50, 50, 50.5, 51, 50.5,
                        47.5, 44, 40.5, 36, 30.5, 28, 25.5, 21.5, 18, 14.5, 10.5, 7.50, 4,
                        2.50, 1.50, 2, 3.50, 7, 12.5, 17.5, 22.5, 25, 25, 25, 25.5, 26.5,
                        27.5, 27.5, 26.5, 23.5, 21, 19, 17, 14.5, 11.5, 8, 4, 1, 0, 0.5, 3,
                        6.50, 10, 13, 16.5, 20.5, 25.5, 29, 33, 35, 36.5, 39, 41};

double t[N];
double tp[M];

double dx[N];
double dy[N];

double qx[N];
double qy[N];
double ux[N];
double uy[N];
double px[N];
double py[N];
double mx[N];
double my[N];

double wyniki_x[M];
double wyniki_y[M];


void ilorazy_roznicowe(double x[], double y[], double d[])
{
    for(int i=1; i<N-1; i++)
    {
        d[i] = 6.0 * ((((y[i+1]-y[i])/(x[i+1] - x[i])) - ((y[i]-y[i-1])/(x[i] - x[i-1]))) / (x[i+1] - x[i-1]));
    }
}

void pomoc(double d[], double q[], double u[], double p[], double h, double lambda)
{
    q[0]=0;
    u[0]=0;
    
    for(int i=1; i<N-1; i++)
    {
        p[i] = lambda * q[i-1] + 2.0;
        q[i] = (lambda - 1.0)/p[i];
        u[i] = (d[i] - lambda*u[i-1])/p[i];
    }
    
}

void licz_m(double u[], double q[], double m[])
{
    m[N-2] = u[N-2];
    for(int i=N-3; i>0; i--)
    {
        m[i] = u[i] + q[i]*m[i+1];
    }
}

double wartosc(double o, double h, double m[], double x[], double y[])
{
    int k=0;
    for(int i=1; i<N; i++)
    {
        if((x[i-1] <= o) && (o <= x[i]))
        {
            k=i;
            break;
        }            
    }


    double a = (1.0/6.0) * m[k-1] * pow((x[k]-o), 3);
    double b = (1.0/6.0) * m[k] * pow((o-x[k-1]),3);
    double c = (y[k-1] - ((1.0/6.0) * m[k-1]*h*h)) * (x[k] - o);
    double e = (y[k] - ((1.0/6.0) * m[k]*h*h)) * (o - x[k-1]);

    return (1.0/h) * (a+b+c+e);
}

int main()
{
    double h = 1.0/(N-1);
    double hp = 1.0/(M-1);
    double lambda = 0.5;

    for(int i=0; i<N; i++)  //inicjalizacja t[]
    {
        t[i] = 1.0*i/(N-1);
    }


    for(int i=0; i<M; i++)  //inicjalizacja t[]
    {
        tp[i] = 1.0*i/(M-1);
    }

    ilorazy_roznicowe(t,wartosci_x,dx);
    ilorazy_roznicowe(t,wartosci_y,dy);


    pomoc(dx,qx,ux,px,h,lambda);
    pomoc(dy,qy,uy,py,h,lambda);

    licz_m(ux, qx, mx);
    licz_m(uy, qy, my);

    for(int i=0; i<M; i++)
    {
        wyniki_x[i] = wartosc(tp[i], hp, mx, t, wartosci_x);
        wyniki_y[i] = wartosc(tp[i], hp, my, t, wartosci_y);
    }
    for(int i=0; i< M; i++)
    {
        cout << wyniki_x[i] << ' ' << wyniki_y[i] << '\n';
    }

    return 0;
}