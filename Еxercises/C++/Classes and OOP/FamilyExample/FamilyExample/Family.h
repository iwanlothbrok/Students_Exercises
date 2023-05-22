#pragma once
#include <iostream>
#include <string>
#include <vector>

using namespace std;
class Family
{
public:
	string name;
	int age;
	vector<string> Members;

	Family() {};
	Family(string name, int age)
	{
		this->name = name;
		this->age = age;
	}

	void Write()
	{
		for (string str : Members) {
			cout << str << std::endl;
		}
	}

	void Speak()
	{
		cout << "Hi form family";
	}
};

