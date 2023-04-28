#pragma once
#include"MilitaryUnit.h"

const double CostStorm = 2.5;

class StormTroopers :public MilitaryUnit
{
public:
	StormTroopers(): MilitaryUnit(CostStorm) {}
	
	void EnduranceStormTroopers() {
		MilitaryUnit::IncreaseEndurance();
	}
	int GetEnduranceStormTroopers() {
		return MilitaryUnit::getEndureance();
	}
};