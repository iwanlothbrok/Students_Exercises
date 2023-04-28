#pragma once
#include"Weapon.h"

const int NuclearPrice = 15;

class NuclearWeapon :public Weapon
{
	NuclearWeapon() {};
	NuclearWeapon(int DestructionLevel): Weapon(NuclearPrice, DestructionLevel) {

	}
};

//NuclearWeapon
//Price of 15 billion QUID.
//The constructor should take the following values upon initialization : int destructionLevel
// 