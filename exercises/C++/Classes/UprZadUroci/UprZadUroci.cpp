#include <iostream>
using namespace std;
#include"BioChemicalWeapon.h"
#include"Planet.h"
#include"MilitaryUnit.h"
#include"AnonymousImpactUnit.h"
#include"vector"

int main()
{
	//MilitaryUnit unit = MilitaryUnit(100);
	AnonymousImpactUnit unit;



	Planet p1;


	p1.AddUnit(unit);

 	p1.setMilitaryPower();


	//vector<int> numbers = { 1,5,16,856 };

	//numbers.push_back(10);
	//cout << numbers.size() << endl;
	//numbers.pop_back();
	//cout << numbers.size() << endl;
	//numbers.begin();
	//numbers.clear();

}
//
//Weapon is a base class of any type of weaponand it should not be able to be instantiated.
// Every Planet can possess only one Weapon from each type in it’s collection of weapons.
//Data
//•	Price – double - in billions QUID(Quasi Universal Intergalactic Denomination)
//•	DestructionLevel –  int
//o	The destruction level is a value between 1 and 10.
//o	If the level is below 1, throw an ArgumentException with a message :
//"Destruction level cannot be zero or negative."
//o	If exceeds 10, throw an ArgumentException with a message : "Destruction level cannot exceed 10 power points."
//Constructor
//The constructor should take the following values upon initialization :
//int destructionLevel, double price

