// 02.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
//Да се състави програма, чрез която се въвеждат N(N <= 20) цели числа, като N се въвежда от клавиатурата.
//Програмата да изведе сумата на положителните и броят на отрицателните въведени числа.Да се използват подходящи функции.
//
//Вход
//Първият ред съдържа едно естествено число N(N <= 20).
//Вторият ред съдържа N цели числа.
//
//Изход
//Сумата на положителните и броят на отрицателните въведени числа, разделени с една празна позиция.

#include <iostream>
#include <climits>

using namespace std;


void sumAndCount(int n, int& sum, int& countOdd)
{
    for (int i = 0; i < n; i++)
    {
        int ch;
        cin >> ch;
        if (ch > 0)
        {
            sum += ch;
        }
        if (ch < 0)
        {
            countOdd++;
        }
    }
}

int main()
{
    int n;
    cin >> n;

    int sum = 0;
    int countOdd = 0;

    sumAndCount(n, sum, countOdd);
    cout << sum << " " << countOdd << endl;



    return 0;
}
