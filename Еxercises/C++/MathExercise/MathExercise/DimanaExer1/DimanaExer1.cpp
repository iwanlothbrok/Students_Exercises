#include <iostream>

using namespace std;

int count_divisors(int num);

int main()
{
    //Дадена е редица от n цели числа, не по-големи от 1000.
    //Да се напише програма, която намира броя на тези от тях,
    //които имат точно m на брой делители (без 1 и самото число).
    int n, m, ch;
    cin >> n;
    cin >> m;

    int count_num = 0;

    for (int i = 0; i < n; i++)
    {

        cin >> ch;
        if (count_divisors(ch) == m)
        {
            count_num++;
        }

    }
    cout << count_num;
    return 0;
}
int count_divisors(int num)
{
    int br = 0;

    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            br++;

            if (num / i != i)
            {
                br++;
            }
        }
    }
    return br;
}
