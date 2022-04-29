# include <bits/stdc++.h>

using namespace std;

int tab [1000000];

int main()
{
    int liczba;
    cin >> liczba;

    
    for (int i = 0; i < 1000000; i++)
    {
       // tab[i] = -10000000;
    }
    tab[0] = 0;
    

    for(int i=0; i<liczba; i++)
    {
        int val;
        cin >> val;

        int j=1000000-1;
       /* for(j=1000000-1; j>=2*val; j--)
        {
           // tab[j] = max({tab[j], tab[j-val], tab[j-2*val] + val});
        }
        for(j = 2*val; j>=val; j--)
        {
            //tab[j] = max(tab[j], tab[j-val]);
        }*/
    }
/*
    for (int i = 0; i < 1000000; i++)
    {
        cout << tab[i] << '\n';
    }
*/

    return 0;
}