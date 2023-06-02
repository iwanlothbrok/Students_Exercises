//Да се състави програма, чрез която се въвеждат N(N <= 20) цели числа, като N се въвежда от клавиатурата.
//Програмата да изведе първото отрицателно число и сумата на четните числа, въведени преди него.
//Ако няма въведени отрицателни числа, на съответното място да се изведе “NO”.Да се използват подходящи функции.
//
//Вход
//Първият ред съдържа едно естествено число N(N <= 20).
//Вторият ред съдържа N цели числа.



#include <iostream>

using namespace std;


void sumAndCount(int n, int& sum, int& minN)
{
    for (int i = 0; i < n; i++)
    {
        int ch;
        cin >> ch;
        if (ch % 2 == 0)
        {
            if (ch > 0)
            {
                sum += ch;
            }
        }
        if (ch < 0 && minN == 0)
        {
            minN = ch;
        }
    }
}

int main()
{
    int n;
    cin >> n;

    int negN = 0;
    int sum = 0;
    sumAndCount(n, sum, negN);

    if (negN == 0)
    {
        cout << "NO" << " " << sum << endl;

    }
    else
    {
        cout << negN << " " << sum << endl;
    }
    return 0;
}
