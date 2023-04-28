#include <iostream>
using namespace std;

int main()
{
	string input = "Hello World!";

	int len = input.length();

	// делим на се взимат двете части на стринг
	for (int i = 0; i < len / 2; i++)
	{
		char temp = input[i];
		input[i] = input[len - i - 1];
		input[len - i - 1] = temp;
	}

	cout << input;
}
