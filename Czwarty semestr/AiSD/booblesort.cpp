#include <iostream>

using namespace std;

int T[100];

void bubble_sort(int* tab, int n) 
{
    for (int i = 0; i < n - 1; ++i)
    {
        if (tab[i] > tab[i + 1]) 
        {  
            swap(tab[i], tab[i + 1]);
        }
    }
}

int main()
{
    cout << rand();

    return 0;
}