// ConvertingCharOrStringToLowerOrToUpperCase.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
	string input;

	cin >> input;
	//GETTING CHAR SIZE
	/*int len = sizeof(input) / sizeof(input[0]);*/

	//GETTING STRING SIZE 
	int length = input.size();


 	for (int i = 0; i < length; i++)
	{
		// converting to lower case
		input[i] += 32;
		cout << input[i];


		//converting to upper case
		//input[i] -= 32;
	}
}

