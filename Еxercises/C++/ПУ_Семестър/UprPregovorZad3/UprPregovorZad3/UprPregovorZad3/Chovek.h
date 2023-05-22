#pragma once
#include<iostream>
class Chovek
{
protected:
	unsigned long int egn;
	char fam[50];
	char adr[50];
	char email[50];
public:
	Chovek() {}
	Chovek(const char* fam, const char* adr, const char* email) {
		strcpy(this->fam, fam);
		strcpy(this->adr, adr);
		strcpy(this->email, email);
	}


};

