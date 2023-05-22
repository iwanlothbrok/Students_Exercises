#pragma once
#include"Chovek.h"
#include"Otgovornik.h"

class StudentBrigadir:public Chovek
{	
private:
	int fakNum;
	char uni[50];
	char specialnost[50];
	Otgovornik* otgovornikB;
public:
	StudentBrigadir(){}
	StudentBrigadir(int fakNum, const char* uni, const char* specialnost,Otgovornik* otgovornikB,const char* fam,const char* adr,const char* email):Chovek( fam,  adr, email) {
		this->fakNum = fakNum;
		strcpy(this->uni, uni);
		strcpy(this->specialnost, specialnost);
		this->otgovornikB = otgovornikB;
	}
};

