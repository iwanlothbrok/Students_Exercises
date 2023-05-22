#pragma once
#include <string>
#include <iostream>

using namespace std;

class People
{
public:
	string Name;
	int age;
	People(string name, int age)
	{
		Name = name;
		this->age = age;
		//setting value by defult 
		this->money = 0;
	}
	void IncreaseSalary()
	{
		// increase hidden property without touching it
		this->money += 2000;
		cout << this->money;
	}

	int PrintAge() {
		this->age += 5;
		cout << age << endl;
	}

	//encaps(hide it)
private:
	int money;
};

