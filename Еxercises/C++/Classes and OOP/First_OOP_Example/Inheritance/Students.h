#include "People.h"

#pragma once
class Students : People {
public:
	Students(string name, int age) : People(name, age) {

	}

	void PrintName() {
		cout << this->Name;
	}
	// polymophism
	void PringAge() {
		this->age += 10;
		cout << this->age << endl;;
	}
};


