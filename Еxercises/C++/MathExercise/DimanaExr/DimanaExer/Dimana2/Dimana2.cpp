#include <iostream>
#include <cmath>
#include <climits>
using namespace std;

bool isInSquare(int x, int y, int a);

int sum(int x, int y);

int main()
{
    int n, a;
    cin >> n;
    cin >> a;

    int minDistance = INT_MAX;


    for (int i = 0; i < n; i++)
    {
        int x, y;

        cin >> x;
        cin >> y;

        if (isInSquare(x, y, a) != true)
        {

            if (minDistance > sum(x, y))
            {
                minDistance = sum(x, y);
            }
        }
    }

    if (minDistance == INT_MAX)
    {
        cout << "0";
    }
    else
    {
        cout << minDistance;
    }

    return 0;
}

bool isInSquare(int x, int y, int a)
{
    return abs(x) <= a / 2 && abs(y) <= a / 2;
}

int sum(int x, int y)
{
    return abs(x) + abs(y);
}