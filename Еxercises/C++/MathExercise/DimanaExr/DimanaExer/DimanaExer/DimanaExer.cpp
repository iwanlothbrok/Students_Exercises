#include <iostream>

using namespace std;

int sum(int ch);

int main()
{

    //Напишете програма, която намира най-голямото произведение,
    //което може да се получи след поставянето на знак за умножение между две от трите цифри на трицифрени числа,
    // въвеждани от клавиатурата. Програмата да спира при въвеждане на 0.
    int ch;
    int maxSum = 0;
    cin >> ch;
    while (ch != 0)
    {
        int incomeSum = sum(ch);
        if (incomeSum > maxSum)
        {
            maxSum = incomeSum;
        }
        cin >> ch;
    }

    cout << maxSum;

    return 0;
}

int sum(int ch)
{
    int digit1 = ch / 100;
    int digit3 = ch % 10;


    int asd = ch % 100;
    int sad = ch / 10;

    int sumLastTwo = (ch % 100) * digit1;

    int sumFirstTwo = (ch / 10) * digit3;

    if (sumFirstTwo > sumLastTwo)
    {
        return sumFirstTwo;
    }

    return sumLastTwo;
}
