#pragma once
#include"Weapon.h"

const double BioPrice = 3.2;

class BioChemicalWeapon : public Weapon
{
public:
	BioChemicalWeapon() {};
	BioChemicalWeapon(int DestructionLevel) : Weapon(BioPrice, DestructionLevel) {

	}
};
//double Price;
//int DestructionLevel;
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
