#pragma once
#include"MilitaryUnit.h"
const double CostAnonymous = 30;

class AnonymousImpactUnit: public MilitaryUnit
{
public:
	AnonymousImpactUnit(): MilitaryUnit(CostAnonymous) {
	
	}

	void EnduranceAnonymousImpactUnit() {
		MilitaryUnit::IncreaseEndurance();
	}

	int GetEnduranceAnonymousImpactUnit() {
		return MilitaryUnit::getEndureance();
	}
};

