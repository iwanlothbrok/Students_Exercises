#pragma once
#include <string>
#include <iostream>
using namespace std;
//example of encapsulation 
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

	//encaps(hide it)
private:
	int money;
};

