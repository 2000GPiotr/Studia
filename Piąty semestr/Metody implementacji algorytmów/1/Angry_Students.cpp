#include <iostream>

using namespace std;

int main()
{
    int groups;
    int students;
    int counter, maks=0;

    cin >> groups;
    for(int i=0; i<groups; i++)
    {
        counter = 0;
        maks = 0;
        cin >> students;
        string group;

        cin >> group;

        for(int j=students-1; j>=0; j--)
        {
            if(group[j] == 'P')
            {
                counter++;
            }
            else
            {
                maks = max(maks, counter);
                counter = 0;
            }
        }     

        cout << maks << '\n';
    }
    
    return 0;
}