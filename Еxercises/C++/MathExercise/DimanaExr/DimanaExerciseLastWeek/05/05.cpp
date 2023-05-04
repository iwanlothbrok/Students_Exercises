#include <iostream>

using namespace std;
bool proverka(int num);
int main()
{
    //Да се напише програма, която въвежда цели числа от клавиатурата.
    //Програмата да намира и извежда броя на тези от тях,
    //които са трицифрени. Да се дефинира и използва подходяща функция.
    //Въвеждането продължава до въвеждане на 0.
    int ch;
    int br = 0;
    cin >> ch;
    while (ch != 0) {

        if (proverka(ch))
        {
            br++;
        }
        cin >> ch;
    }

    cout << br << endl;
    return 0;
}
bool proverka(int num)
{
    int br = 0;
    while (num != 0) {
        br++;
        num /= 10;
    }

    if (br == 3) {
        return true;
    }
    return false;
}
