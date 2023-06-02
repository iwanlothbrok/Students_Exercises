// 01.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

//
//Да се състави програма, чрез която се въвеждат N(N <= 20) естествени числа от интервала[10..999], като N се въвежда от
//  клавиатурата.Програмата да изведе въведените числа с най - малка и най - голяма стойност, 
// както и средната стойност на всички въведени числа.Програмата да извършва проверка за валидност на въвежданите данни.
// Да се използват подходящи функции.
//
//Вход
//Първият ред съдържа едно естествено число N(N <= 20).
//Вторият ред съдържа последователност от цели числа.


#include <iostream>
#include <climits>

using namespace std;


double average(int n, int& minN, int& maxN)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {

        int ch;
        cin >> ch;
        if (ch < 10 || ch > 999)
        {
            i--;
            continue;
        }

        if (ch >= 10 && ch <= 999)
        {

            if (ch < minN)
            {
                minN = ch;
            }
            if (ch > maxN)
            {
                maxN = ch;
            }

            sum += ch;
        }
    }

    return (double)sum / n;
}

int main()
{
    int n;
    cin >> n;

    int minN = INT_MAX;
    int maxN = INT_MIN;


    double avg = average(n, minN, maxN);
    cout << minN << " " << maxN << " " << avg << endl;


    return 0;
}