#pragma once
#include <iostream>
using namespace std;
#include <stdexcept>
#include"MilitaryUnit.h"
#include"Weapon.h"
#include"vector"

class Planet
{
private:
	vector<MilitaryUnit> mUnit;
	Weapon w;
	string Name;
	double Budget;
	double MilitaryPower;

public:
	void setName(string Name){
		if (Name.empty()) {
			throw new invalid_argument("Planet name cannot be null or empty.");
		}
		this->Name = Name;
	}
	string getName() {
		return Name;
	}
	void setBudget(double Budget) {
		if (Budget < 0) {
			throw new invalid_argument("Budget's amount cannot be negative.");
		}
		this->Budget = Budget;
	}
	double getBudget() {
		return Budget;
	}
	void setMilitaryPower() {
		MilitaryPower = sumOfEndurances() + w.getDestructionLevel(); // TODO


	}

	int sumOfEndurances() {

		int sum = 0;

		for (auto& unit : mUnit)
		{
			sum += unit.getEndureance();
		}

		return sum;
	}

	void AddUnit(MilitaryUnit unit) {
		this->mUnit.push_back(unit);
	}
};

// TODO 
// to get sum with foreach 
// foreach (minawame prez wseki unit)
// foreach(unit a in nUnut)  
//  sum += a.getEndurance;
// 
// sloji w kolekcii weapon i unit

