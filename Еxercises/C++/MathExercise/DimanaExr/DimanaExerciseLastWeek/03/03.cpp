#include <iostream>

using namespace std;

void deliteli(int ch);
int main()
{
    int n;
    cin >> n;
    int num;
    for (int i = 1; i <= n; i++)
    {
        cin >> num;
        deliteli(num);
    }

    return 0;
}
void deliteli(int ch)
{
    for (int i = 1; i <= ch; i++)
    {
        if (ch % i == 0)
        {
            cout << i << " ";
        }
    }
    cout << endl;
}
