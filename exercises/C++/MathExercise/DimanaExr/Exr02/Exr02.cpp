#include <iostream>
using namespace std;

void SortAscending(int& a, int& b, int& c);
int main()
{
    int ch1, ch2, ch3;


    for (int i = 0; i < 4; i++)
    {
        cin >> ch1 >> ch2 >> ch3;

        SortAscending(ch1, ch2, ch3);

        cout << ch1 << ' ' << ch2 << ' ' << ch3 << endl;
    }
    return 0;
}
void SortAscending(int& a, int& b, int& c)
{
    if (a > b)
    {
        swap(a, b);
    }
    if (a > c)
    {
        swap(a, c);
    }
    if (b > c)
    {
        swap(b, c);
    }
}
