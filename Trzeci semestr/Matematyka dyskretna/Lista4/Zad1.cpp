#include<iostream>

using namespace std;

int main()
{
    int a=71;
    for(int i=0; i<71; i++)
    {
        a*=71;
        a%=100;
        cout << i+2 << ' ' << a << endl;
    }

    return 0;
}