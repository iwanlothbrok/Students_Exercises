// GetterAndSetter_Example.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Person.h"

using namespace std;

int main()
{
	Person iwo;

	iwo.setAge(10);

	cout << iwo.getAge();
}

