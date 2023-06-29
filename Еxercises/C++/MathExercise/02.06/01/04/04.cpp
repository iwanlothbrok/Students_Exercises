//Да се състави функция, чрез която се въвежда редица от N(N <= 20) цели числа и се сортира.Като се използва тази функция, 
//да се въведат две редици от цели числа(с брой на елементите m и n) и да се сортират.Получените сортирани редици да се обединят
//в една също сортирана редица.Да се изведе получената редица.Броят на елементите на двете редици се въвежда от клавиатурата.
//
//Вход
//Първият ред съдържа едно естествено число m(m <= 20).
//Вторият ред съдържа m цели числа.
//Третият ред съдържа едно естествено число n(n <= 20).
//Четвъртият ред съдържа n цели числа.
#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 20;


void mergeSequences(int sequence1[], int size1, int sequence2[], int size2, int mergedSequence[])
{
    int i = 0, j = 0, k = 0;


    while (i < size1 && j < size2)
    {
        if (sequence1[i] <= sequence2[j])
        {
            mergedSequence[k] = sequence1[i];
            i++;
        }
        else
        {
            mergedSequence[k] = sequence2[j];
            j++;
        }
        k++;
    }


    while (i < size1)
    {
        mergedSequence[k] = sequence1[i];
        i++;
        k++;
    }


    while (j < size2)
    {
        mergedSequence[k] = sequence2[j];
        j++;
        k++;
    }
}
int main()
{
    int arr[MAX_SIZE], secondArr[MAX_SIZE];

    int mixed[MAX_SIZE * 2];


    int n;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        std::cin >> arr[i];
    }


    int m;
    cin >> m;
    for (int i = 0; i < m; i++)
    {
        std::cin >> secondArr[i];
    }

    sort(arr, arr + n);
    sort(secondArr, secondArr + m);

    mergeSequences(arr, n, secondArr, m, mixed);

    int sizeArr = n + m;

    for (int i = 0; i < sizeArr; i++)
    {
        cout << mixed[i] << " ";
    }

    return 0;
}
