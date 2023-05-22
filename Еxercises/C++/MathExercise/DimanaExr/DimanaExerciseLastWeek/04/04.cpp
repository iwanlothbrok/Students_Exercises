#include <iostream>

using namespace std;

bool ednakviCifri(int num1);
int main()
{
    int m, n;
    cin >> m >> n;
    while (m != 0 && n != 0)
    {
        bool isFound = false;
        for (int i = m; i <= n; i++)
        {
            if (i < 0 & ednakviCifri(i))
            {
                cout << i << " ";
                isFound = true;
            }
            else if (ednakviCifri(i))
            {
                cout << i << " ";
                isFound = true;
            }
        }
        if (isFound)
        {
            cout << endl;
        }
        if (isFound == false)
        {
            cout << "NO" << endl;
        }
        cin >> m >> n;
    }
    return 0;
}
bool ednakviCifri(int num1)
{
    if (num1 % 11 == 0)
    {
        return true;
    }

    return false;
}
