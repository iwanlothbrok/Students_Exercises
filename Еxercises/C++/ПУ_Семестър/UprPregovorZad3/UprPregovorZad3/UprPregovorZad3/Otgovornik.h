#pragma once
#include"Chovek.h"
class Otgovornik:public Chovek
{
private:
	char imeF[50];
	char naselM[50];
	char durjava[50];
public:
	Otgovornik(){}
	Otgovornik(const char* imeF, const char* naselM, const char* durjava, const char* fam,const char* adr, const char* email):Chovek(fam, adr, email) {
		strcpy(this->imeF, imeF);
		strcpy(this->naselM, naselM);
		strcpy(this->durjava, durjava);
	}

};

