#include <iostream>
#include "../First_OOP_Example/People.h"
using namespace std;

int main()
{
	People* iwan = new People("Iwan", 23);

	iwan->IncreaseSalary();
}
