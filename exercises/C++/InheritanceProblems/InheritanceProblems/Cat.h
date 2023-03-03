#pragma once
#include "Animal.h"

class Cat : public Animal
{
protected:
	string gender;

	Cat() {
		this->gender = "None";
	}
};

