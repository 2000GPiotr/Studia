# include <iostream>
# include <cmath>

using namespace std;

double f(double x)
{
	return 4040 * (sqrt (pow(x, 11) + 1) - 1) / pow(x, 11);
}

double betterf(double x)
{
	return 4040 / (sqrt(pow(x, 11) + 1 ) + 1);
}

int main()
{
		cout << " -> " << f(0.001) << endl;
		cout  << " --> " << betterf(0.001) << endl;
		
	return 0;
}
