// Inheritance.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "../First_OOP_Example/People.h"
#include "Students.h";
int main()
{
	
	People* p1= new People("Iwo",15);
	Students* s1= new Students("Petyrcho", 30);

	p1->PrintAge();//output 20
	s1->PringAge(); //output 40;
}

