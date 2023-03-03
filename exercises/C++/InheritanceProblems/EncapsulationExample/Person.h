#pragma once
#include <iostream>
using namespace std;


class Person
{
	// protected because we dont want anyone to modify them
protected:
	string Name;
	int Age;


	// getters and setters for the props/ that is the way of setting and getting the values
public:
	void SetName(string name) {
		this->Name = name;
	}
	string GetName() {
		return this->Name;
	}

	void SetAge(int age) {
		if (age < 18) {

			return;
		}

		this->Age = age;
	}
	int GetAge() {
		return this->Age;
	}
};

