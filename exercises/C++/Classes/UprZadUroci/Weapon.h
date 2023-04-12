#pragma once
#include <string>
using namespace std;
#include <stdexcept>


class Weapon
{
protected:
	double Price;
	int DestructionLevel;
public:
	Weapon() {};
	Weapon(double Price, int DestructionLevel) {
		setPrice(Price);
		setDestructionLevel(DestructionLevel);
	}
	void setPrice(double Price) {
		this->Price = Price;
	}
	double getPrice() {
		return Price;
	}
	void setDestructionLevel(int DestructionLevel) {
		if (DestructionLevel < 1 || DestructionLevel>10) {
			throw new invalid_argument("Destruction level error");
		}
		this->DestructionLevel = DestructionLevel;
	}
	int getDestructionLevel() {
		return DestructionLevel;
	}
};

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
//
//BioChemicalWeapon
//Price of 3.2 billion QUID.
//The constructor should take the following values upon initialization : int destructionLevel
// 
//NuclearWeapon
//Price of 15 billion QUID.
//The constructor should take the following values upon initialization : int destructionLevel
// 
//SpaceMissiles
//Price of 8.75 billion QUID.
//The constructor should take the following values upon initialization : int destructionLevel
