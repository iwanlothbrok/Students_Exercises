#include <iostream>
using namespace std;

// Function to count the number of integers with digit 6
int countNumbersWithDigitSix() {
    int num, count = 0;
    cout << "Enter a positive integer (or 0 to quit): ";
    cin >> num;
    while (num != 0) {
        // Check if num contains digit 6
        while (num > 0) {
            int digit = num % 10;
            if (digit == 6) {
                count++;
                break;  // exit inner loop if digit 6 is found
            }
            num /= 10;
        }
        // Prompt user for another input
        cout << "Enter a positive integer (or 0 to quit): ";
        cin >> num;
    }
    return count;
}

int main() {
    int count = countNumbersWithDigitSix();
    cout << "The number of integers with digit 6 is: " << count << endl;
    return 0;
}
