#pragma once
#include <string>
#include <iostream>

using namespace std;


class Animal
{
protected:
	string name;
	int age;

public:
	Animal() {
		this->name = "Animal";
	}

	Animal(string name, int age) {
		this->name = name;
		this->age = age;
	}

	void Speak() {
		cout << "I am animal." << endl;
	}
};

