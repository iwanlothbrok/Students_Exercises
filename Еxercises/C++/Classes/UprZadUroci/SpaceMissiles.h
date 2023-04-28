#pragma once

#include"Weapon.h"

const double SpacePrice = 8.75;

class SpaceMissiles :public Weapon
{
	SpaceMissiles() {};
	SpaceMissiles(int DestructionLevel) : Weapon(SpacePrice, DestructionLevel) {

	}

};
//SpaceMissiles
//Price of 8.75 billion QUID.
//The constructor should take the following values upon initialization : int destructionLevel

