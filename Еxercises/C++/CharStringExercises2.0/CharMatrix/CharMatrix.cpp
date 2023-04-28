#include <iostream>
using namespace std;

int main()
{
	char firstChar, secondChar;

	cin >> firstChar >> secondChar;

	for (char i = firstChar; i <= secondChar; i++)
	{
		for (char z = firstChar; z <= secondChar; z++)
		{
			for (char x = firstChar; x <= secondChar; x++)
			{
				cout << i << z << x << endl;
			}
		}
	}
}

