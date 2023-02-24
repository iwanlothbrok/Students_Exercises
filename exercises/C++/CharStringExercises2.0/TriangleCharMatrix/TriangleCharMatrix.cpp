#include <iostream>
using namespace std;

int main()
{
	char lastChar;

	cin >> lastChar;
	//first printing to all chars in one row 
	//A
	//AB
	//ABC
	for (char i = 'A'; i <= lastChar; i++)
	{
		for (char z = 'A'; z <= i; z++)
		{
			cout << z;
		}
		cout << endl;
	}
	//SECOND REVERSE PRINTING 
	//BA
	//A

	for (char x = lastChar - 1; x >= 'A'; x--)
	{
		for (char j = 'A'; j <= x; j++)
		{
			cout << j;
		}
		cout << endl;
	}
}

