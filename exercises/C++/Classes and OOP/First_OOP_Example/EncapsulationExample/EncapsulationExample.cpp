#include <iostream>
#include "../First_OOP_Example/People.h"
using namespace std;

int main()
{
	People iwan = People("Iwan", 23);

	cout << iwan.Name << endl;
	cout << iwan.age << endl;
}
