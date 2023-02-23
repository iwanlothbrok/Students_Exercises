// 01.SumSeconds.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


int main()
{
	int first, second, third;

	cin >> first >> second >> third;

	int totalTime = first + second + third;

	int minutes = totalTime / 60;
	int seconds = totalTime % 60;


	if (seconds > 10) {

		cout << minutes << ":" << seconds;
	}

	else {
		cout << minutes << ":" << "0" << seconds;
	}

}

