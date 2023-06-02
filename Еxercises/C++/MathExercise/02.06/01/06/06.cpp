//Да се състави функция, чрез която се въвежда последователност от не повече от  20 символа и друга функция,
//  която заменя главните латински букви с малки, а малките – с главни.Като се използват тези функции, 
// да се въведат две последователности от по не повече от 20 символа и да се заменят главните латински букви
//  в тях с малки, а малките – с главни.Получените низове да се сортират и да се обединят в един също сортиран низ.
// Да се изведе полученият низ.
//
//Вход
//Първият ред съдържа последователност от не повече от 20 символа.
//Вторият ред съдържа последователност от не повече от 20 символа.

#include <iostream>
#include <cstring>
#include <algorithm>

using namespace std;


void swapCase(char arr[])
{
    int lenght = strlen(arr);

    for (int i = 0; i < lenght; i++)
    {
        if (islower(arr[i]))
        {
            arr[i] = toupper(arr[i]);
        }
        else if (isupper(arr[i]))
        {
            arr[i] = tolower(arr[i]);
        }
    }
}

void mergeArray(char arr1[], char arr2[], char mixed[])
{
    int firstSize = strlen(arr1);
    int secondSize = strlen(arr2);


    strcpy(mixed, arr1);
    strcat(mixed, arr2);
}

int main()
{
    char arr[21], secondArr[21];


    cin.getline(arr, 21);
    cin.getline(secondArr, 21);

    char mixed[42];

    swapCase(arr);
    swapCase(secondArr);


    mergeArray(arr, secondArr, mixed);

    int sizeArr = strlen(mixed);

    sort(mixed, mixed + sizeArr);

    for (int i = 0; i < sizeArr; i++)
    {
        cout << mixed[i];
    }

    return 0;
}
