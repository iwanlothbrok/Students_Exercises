#include <iostream>
using namespace std;
int counter(int number[], int sizeN);

int main()
{
    int n;
    cin >> n;

    int numbers[100];
    int ch;
    for (int i = 0; i < n; i++)
    {
        cin >> ch;
        numbers[i] = ch;
    }

    int m;
    cin >> m;

    int numbers2[100];
    for (int i = 0; i < m; i++)
    {
        cin >> ch;
        numbers2[i] = ch;
    }

    int firstC = counter(numbers, n);
    cout << firstC;

    return 0;
}

int counter(int number[], int sizeN)
{
    int counter = 0;

    for (int i = 0; i < sizeN; i++)
    {
        int first = number[i];
        for (int k = i; k <= sizeN - 1; k++)
        {
            int second = number[k];

            if (first != second)
            {
                counter++;
            }
        }
    }

    return counter;

}
