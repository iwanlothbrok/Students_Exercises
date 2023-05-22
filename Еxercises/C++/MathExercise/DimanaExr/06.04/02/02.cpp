#include <iostream>
using namespace std;

// Function to print digits in reverse order
void printDigitsInReverse(int num) {
    while (num > 0) {
        int digit = num % 10;
        cout << digit;
        num /= 10;
    }
}

int main() {
    int num;
    cout << "Enter a positive integer (or 0 to quit): ";
    cin >> num;
    while (num != 0) {
        cout << "Digits in reverse order: ";
        printDigitsInReverse(num);
        cout << endl;
        cout << "Enter a positive integer (or 0 to quit): ";
        cin >> num;
    }
    return 0;
}
