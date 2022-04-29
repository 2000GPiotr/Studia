# include <iostream>
# include <cmath>

using namespace std;

int main()
{
	double pival[100];
	
	pival[1] = 2.0;
	
	
	for(int k=1; k<99; k++)
	{
		pival[k+1] = pow(2.0, k) * sqrt(2 * (1 - sqrt(1 - pow((pival[k]) / pow(2.0, k), 2))));
	}
	
	//-----------------------------------------
	
	double betterpival[100];
	
	betterpival[1] = 2.0;
	
	
	for(int k=1; k<99; k++)
	{
		betterpival[k+1] = pow(2.0, k) * sqrt(2 * pow((betterpival[k] / pow(2.0, k)), 2.0) / (1 + sqrt(1 - pow((betterpival[k] / pow(2.0, k)), 2.0))));
	}
	
	
	
	for(int k=1; k<100; k++)
	{
		cout << k << ' ' << pival[k] << '\n';
	}
	
	cout << "---------------------------" << endl;
	
	for(int k=1; k<100; k++)
	{
		cout << k << ' ' << betterpival[k] << '\n';
	}	
	return 0;
}
