#pragma once
#include"StudentBrigadir.h"
#include<ctime>
#include<iostream>
#include"TFibonacci.h"
using namespace std;
// for do kraq na kolekciqta na struct 
// otdelna fuknciq na koqto shte podame imeto na firmata w koqto rabotqt, koi e otgowornik ]
// promenliwa sum koqto e wyw func
// w tazi func minawame prez wseki student 
// i prawim edna proweka dali studentyt raboti w tazi firma 
// ako raboti dobawame kolichestwoto w sumata 

//

struct Earnings
{
	int data;
	StudentBrigadir* sB;
	char material[50];
	int nabrKol;
	int getKolich() {
		return nabrKol;
	}
	void printData() {
		cout << data << " " << sB << " " << material <<" "<< nabrKol<< endl;
	}
};

class Zarabotka
{
public:
	Zarabotka() {
		limit = fib.NextNumber();
		earnings[limit];
		current = 0;
	}

	void addS(int data, StudentBrigadir *sB,const char* material,int nabrKol) {
		if (current == limit) {
			limit = fib.NextNumber();
			earnings[limit];
		}

		earnings[current].sB = sB;
		current++;
	}

private:
	//earnings[512];
	int current;
	int limit;
	TFibonacci fib;
	Earnings* earnings;
public:
	friend int compareSwap(const void* a, const void* b);
};
int compareSwap(const void* a, const void* b)
{
	Earnings* sB1;
	Earnings* sB2;

	sB1 = (Earnings*)a;
	sB2 = (Earnings*)b;

	if (sB1->getKolich() < sB2->getKolich())
	{ 
		swap(sB1, sB2);
		return 0;
	}

	return 1;
}

Earnings* sorting(const void* arr, const void* size) {

	int currSize = (int)size;
	Earnings* newArr = (Earnings*)arr;


	for (int i = 0; i < currSize-1; i++)
	{
		for (int j = 0; j < currSize-i-1; j++)
		{
			if (newArr[j].getKolich() > newArr[j + 1].getKolich())
			{
				compareSwap(&newArr[j], &newArr[j+1]);
			}
		}
	}


	return newArr;
}
