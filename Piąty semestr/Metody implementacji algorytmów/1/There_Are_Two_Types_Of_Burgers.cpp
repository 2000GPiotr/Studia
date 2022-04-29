#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int queries;
    int buns, beef, chicken;
    int hamburger_price, chickenburger_price;

    int burgers;
    int res;

    vector <int> results;

    cin >> queries;

    for(int i=0; i<queries; i++)
    {
        res=0;
        cin >> buns >> beef >> chicken;
        cin >> hamburger_price >> chickenburger_price;

        if(buns<2)
        {
            results.push_back(0);
        }
        else if(hamburger_price>chickenburger_price)
        {
            burgers = min(buns/2, beef);
            
            res += burgers * hamburger_price;
            buns -= burgers * 2;
            
            burgers = min(buns/2, chicken);

            res += burgers * chickenburger_price;

            results.push_back(res);
        }
        else
        {
            burgers = min(buns/2, chicken);
            
            res += burgers * chickenburger_price;
            buns -= burgers * 2;
            
            burgers = min(buns/2, beef);

            res += burgers * hamburger_price;

            results.push_back(res);
        }
    }
    
    for(int i=0; i<queries; i++)
        cout << results[i] << '\n';

    return 0;
}