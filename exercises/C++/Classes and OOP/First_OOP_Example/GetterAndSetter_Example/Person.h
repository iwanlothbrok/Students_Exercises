#pragma once
class Person
{
private:
	int age;

public:
	//getting our value 
	int getAge() /*const*/ {
		return age;
	}

	void setAge(int inputValue) {
		age = inputValue;
	}

};

