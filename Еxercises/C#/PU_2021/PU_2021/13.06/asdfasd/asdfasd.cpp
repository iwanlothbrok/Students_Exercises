#include <iostream>
#include <cmath>
#include <unordered_set>
using namespace std;

bool isPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i <= sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

void print(int number)
{
    bool hasPrime = false;
    for (int i = 2; i <= sqrt(number); i++)
    {
        if (number % i == 0 && isPrime(i))
        {
            cout << i << " ";
            hasPrime = true;
        }
    }

    if (hasPrime == false)
    {
        cout << "NO";
    }

}

int main()
{

    int n;
    cin >> n;
    int ch;

    int numbers[100];


    for (int i = 0; i < n; i++)
    {
        cin >> ch;
        numbers[i] = ch;

    }
    for (int i = 0; i < n; i++)
    {
        print(numbers[i]);
        cout << endl;
    }
}