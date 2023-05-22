#include <iostream>

using namespace std;

int deliteli(int ch);
int main()
{
    int n;
    cin >> n;

    int maxBr = 0;
    int maxNum = 0;

    while (n != 0)
    {
        if (maxBr < deliteli(n))
        {
            maxBr = deliteli(n);
            maxNum = n;
        }
        cin >> n;
    }
    cout << maxNum << " " << maxBr << endl;
    return 0;
}
int  deliteli(int ch)
{
    int br = 0;
    for (int i = 1; i <= ch; i++)
    {
        if (ch % i == 0)
        {
            br++;
        }
    }
    return br;
}
