#include <iostream>

using namespace std;
bool hasZeroDigit(int num);
bool isMultiple(int num);
int main()
{

	int num;
	bool valid = false;
	do
	{
		cin >> num;

		if (num != 0 && hasZeroDigit(num) == true && isMultiple(num) == true) {
			valid = true;
			cout << num << " ";
		}
	} while (num != 0); {
		if (valid == false) {
			cout << "NO";
		}
	}

	return 0;
}

bool hasZeroDigit(int num)
{
	while (num != 0)
	{
		if (num % 10 == 0)
		{
			return false;
		}
		num /= 10;
	}
	return true;
}

bool isMultiple(int num)
{
	int digit;

	// setvame promenliva sys stoinosta na numbera, zashtoto numbera se promenq a na nas ni trqbwa ne promenenata stoinost
	int staticNumberValue = num;
	while (num != 0)
	{
		digit = num % 10;

		if (digit == 0 || staticNumberValue % digit != 0)
		{
			return false;
		}

		num /= 10;
	}
	return true;
}
