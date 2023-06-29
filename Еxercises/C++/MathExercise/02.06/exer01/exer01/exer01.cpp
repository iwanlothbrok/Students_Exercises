// exer01.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <iostream>

using namespace std;
void Sequence(int sequence[], int sizeNumbers, int& maxLength, int& repeatedNumber);

int main()
{

	int n;
	cin >> n;
	int maxLength = 0;
	int sequenceNumber = 0;

	int numbers[100];

	for (int i = 0; i < n; i++)
	{

		int number;
		cin >> number;

		numbers[i] = number;
	}

	Sequence(numbers, n, maxLength, sequenceNumber);


	int m;
	cin >> m;
	int maxLength1 = 0;
	int sequenceNumber1 = 0;

	int numbers1[100];

	for (int i = 0; i < m; i++)
	{

		int number1;
		cin >> number1;

		numbers1[i] = number1;
	}

	Sequence(numbers1, m, maxLength1, sequenceNumber1);

	if (maxLength > maxLength1)
	{

		cout << maxLength << " " << sequenceNumber;
	}
	else if (maxLength < maxLength1)
	{

		cout << maxLength1 << " " << sequenceNumber1;
	}

}

void Sequence(int sequence[], int sizeNumbers, int& maxLength, int& repeatedNumber)
{

	int length[30];
	int parents[30];


	for (int i = 0; i < sizeNumbers; i++)
	{
		length[i] = 1;
		parents[i] = -1;

		for (int j = 0; j < i; j++)
		{
			int a = sequence[i];
			int b = sequence[j];
			if (sequence[i] > sequence[j] && length[j] + 1 > length[i])//&& length[j] + 1 > length[i]
			{
				length[i] = length[j] + 1;
				parents[i] = j;
			}
		}
	}

	maxLength = 0;
	int maxIndex = 0;

	for (int j = 0; j < sizeNumbers; j++)
	{
		if (length[j] > maxLength)
		{
			maxLength = length[j];
			maxIndex = j;
		}
	}


	repeatedNumber = sequence[maxIndex];


}



