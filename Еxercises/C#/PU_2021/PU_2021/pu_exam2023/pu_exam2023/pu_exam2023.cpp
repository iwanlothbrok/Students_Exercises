// pu_exam2023.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

enum valuta {
	LEV,
	EURO
};

struct Cars {
	int id = 0;
	char brand[31];
	int year = 0;
	double price = 0;
	valuta valuta;
}cars[500];

void addCars(int n) {
	for (int i = 1; i <= n; i++)
	{
		//car id 
		cars[i].id = i;

		//cin.ignore(256, '\n');
		cout << "enter brand" << endl;
		cin.getline(cars[i].brand, 31);

		cout << "enter year" << endl;
		cin >> cars[i].year;
		cin.ignore();

		cout << "enter price" << endl;
		cin >> cars[i].price;

		cin.ignore(256, '\n');
		cout << "enter LEV or EURO" << endl;
		char valuta[6];
		cin.getline(valuta, 6);

		if (strcmp(valuta, "LEV") == 0)
		{
			cars[i].valuta = valuta::LEV;
		}
		else
		{
			cars[i].valuta = valuta::EURO;
		}
	}

	cout << "-------------------------------------------" << endl;
}

void print(int n)
{
	for (int i = 1; i <= n; i++)
	{
		cout << i + 1 + ": ";

		cout
			<< "Id: " << cars[i].id << endl
			<< "Brand: " << cars[i].brand << endl
			<< "Price: " << cars[i].price << endl
			<< "Year: " << cars[i].year << endl;

		if (cars[i].valuta == 0)
		{
			cout << "Valuta: LEV" << endl;
		}
		else {
			cout << "Valuta: EURO" << endl;
		}
	}
}

void printPriceCriteria(int n, double price)
{
	for (int i = 1; i <= n; i++)
	{
		double carPrice = cars[i].price;
		if (cars[i].valuta == 1)
		{
			carPrice *= 1.96;
		}

		if (carPrice < price)
		{
			cout
				<< "Id: " << cars[i].id << endl
				<< "Brand: " << cars[i].brand << endl
				<< "Price: " << cars[i].price << endl
				<< "Year: " << cars[i].year << endl
				<< "Valuta: LEV" << endl;
		}
	}

}

void totalSumInLEV(int n)
{
	double totalSum = 0;
	for (int i = 1; i <= n; i++)
	{
		double carPrice = cars[i].price;
		if (cars[i].valuta == 1)
		{
			carPrice *= 1.96;
		}

		totalSum += carPrice;
	}

	cout << "Total Sum : " << totalSum;
}

void orderByBrandAsc(int n)
{

	for (int i = 1; i <= n; i++)
	{
		for (int j = 1; j <= n - i; j++)
		{
			if (strcmp(cars[j].brand, cars[j + 1].brand) > 0)
			{
				Cars Temp = cars[j];
				cars[j] = cars[j + 1];
				cars[j + 1] = Temp;
			}
			else if (strcmp(cars[j].brand, cars[j+ 1].brand) == 0)
			{
				if (cars[j].price < cars[j+1].price)
				{
					Cars Temp = cars[j];
					cars[j] = cars[j + 1];
					cars[j + 1] = Temp;
				}
			}
		}
	}

}

int main()
{
	// Enter N:
	cout << "ENTER N:" << endl;
	int n;
	cin >> n;
	cin.ignore(256, '\n');
	//adding the cars 
	addCars(n);

	//printing the information about the cars
	//print(n);
	//-----------------
	/*cout << "ENTER PRICE: ";
	double price;
	cin >> price;
	cin.ignore(256, '\n');
	//-----------------
	printPriceCriteria(n, price);*/

	//getting the total sum 
	//totalSumInLEV(n);

	orderByBrandAsc(n);
	print(n);

}
