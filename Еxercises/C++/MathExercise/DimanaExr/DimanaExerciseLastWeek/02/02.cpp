#include <iostream>

using namespace std;

bool prostiCh(int num);
int main()
{
    int ch;
    cin >> ch;
    int br = 0;
    while (ch != 0)
    {
        if (prostiCh(ch))
        {
            br++;
        }
        cin >> ch;
    }
    cout << br << endl;
    return 0;
}
bool prostiCh(int num)
{
    if (num < 2)
    {
        return false;
    }

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
