#include <iostream>

using namespace std;

int count_digits(int num) {
    int count = 0;
    while (num > 0) {
        count++;
        num /= 10;
    }
    return count;
}

int main() {
    int n, num, total_digits = 0;

    cout << "Enter the number of integers: ";
    cin >> n;

    for (int i = 1; i <= n; i++) {
        cout << "Enter integer #" << i << ": ";
        cin >> num;
        total_digits += count_digits(num);
    }

    cout << "Total number of digits: " << total_digits << endl;

    return 0;
}
