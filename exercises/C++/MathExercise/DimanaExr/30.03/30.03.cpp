﻿#include <iostream>

using namespace std;

void figuri(int a);
int main()
{
	int n;

	do {
		cin >> n;

		if (n == 0)
		{
			return 0;
		}
		figuri(n);
	} while (n != 0);

	return 0;
}
void figuri(int a)
{
	int squares = 0;
	int triangles = 0;


	int remain = a;

	while (remain >= 4) {
		squares++;
		remain -= 4;
	}
	while (remain >= 3) // 2
	{
		triangles++;
		remain -= 3;
	}

	if (remain != 0)
	{
		cout << "NO" << endl;
	}
	else {
		cout << squares << ' ' << triangles << endl;
	}

}
///*Да се състави функция, която намира колко отделни 
//квадрати и триъгълници със страна 1 кибритена клечка могат
//да се направят от N кибритени клечки, така че общият брой на 
//фигурите да бъде най - малък и да се използват всички клечки.К
//ато се използва тази функция, да се напише програма, която извежд
//а тези резултати за последователно въвеждани от клавиатурата цели 
//положителни числа(брой кибритени клечки).Ако с въведеният брой кибритени 
//клечки не могат да се направят точен брой фигури, програмата да изведе “NO”.
//Въвеждането да продължи до въвеждане на нула.
//
//Вход
//Последователност от цели положителни числа, завършваща с нула.
//
//Изход
//Всеки ред съдържа броят квадрати и 
////броят триъгълници, които могат да се направят, 
////разделени с една празна позиция.Ако не могат да се 
////направят точен брой фигури, да се изведе "NO".c++ english