#pragma once
#include"MilitaryUnit.h"
const double SpaceCost = 11;

class SpaceForces :public MilitaryUnit{
public:
	SpaceForces(): MilitaryUnit(SpaceCost) {
	
	}
	void EnduranceSpaceForces() {
		MilitaryUnit::IncreaseEndurance();
	}
	int GetEnduranceSpaceForces() {
		return MilitaryUnit::getEndureance();
	}
};

