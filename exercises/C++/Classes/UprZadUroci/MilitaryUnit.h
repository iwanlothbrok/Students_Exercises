#pragma once
#include<string>
#include <stdexcept>
using namespace std;

class MilitaryUnit
{
protected:
	double Cost;
	int EnduranceLevel;
public:
	MilitaryUnit() {};
	MilitaryUnit(double Cost) {
		EnduranceLevel = 1;
		this->Cost = Cost;
	};
	void IncreaseEndurance() {
		EnduranceLevel += 1;

		if (EnduranceLevel > 20) {
			EnduranceLevel = 20;
			throw new invalid_argument("Endurance level cannot exceed 20 power points.");
		}
	}

	int getEndureance()
	{
		return this->EnduranceLevel;
	}
};

