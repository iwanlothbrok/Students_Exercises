#pragma once
#include <iostream>
#include "Family.h"
class Person : Family
{
public:
	Person() {};

	void Speak()
	{
		Family::Speak();
	}
};

