// 05.cpp : This file contains the 'main' function. Program execution begins and ends there.
//Да се състави функция, чрез която се въвежда дума с не повече от 20 символа и се сортира. 
// Като се използва тази функция, да се въведат две думи, всяка с не повече от 20 символа и да се сортират. 
// Получените сортирани низове да се обединят в един също сортиран низ. Да се изведе полученият низ.
//
//Вход
//Първият ред съдържа дума с не повече от 20 символа.
//Вторият ред съдържа дума с не повече от 20 символа.
//

#include <iostream>
#include <cmath>
#include <algorithm>
#include <cstring>

using namespace std;

const int MAX_SIZE = 20;

void mergeSequences(const char word1[], const char word2[], char mergedWord[])
{
    int i = 0, j = 0, k = 0;

    while (word1[i] != '\0' && word2[j] != '\0')
    {
        if (word1[i] <= word2[j])
        {
            mergedWord[k] = word1[i];
            i++;
        }
        else
        {
            mergedWord[k] = word2[j];
            j++;
        }
        k++;
    }

    while (word1[i] != '\0')
    {
        mergedWord[k] = word1[i];
        i++;
        k++;
    }

    while (word2[j] != '\0')
    {
        mergedWord[k] = word2[j];
        j++;
        k++;
    }

    mergedWord[k] = '\0';  // Add null terminator to the merged word
}


int main()
{
    char arr[MAX_SIZE], secondArr[MAX_SIZE];

    char mixed[MAX_SIZE * 2];


    cin.getline(arr, 21);
    cin.getline(secondArr, 21);

    sort(arr, arr + strlen(arr));
    sort(secondArr, secondArr + strlen(arr));

    mergeSequences(arr, secondArr, mixed);

    sort(mixed, mixed + strlen(mixed));

    int sizeArr = strlen(mixed);

    for (int i = 0; i < sizeArr; i++)
    {
        cout << mixed[i];
    }

    return 0;
}
