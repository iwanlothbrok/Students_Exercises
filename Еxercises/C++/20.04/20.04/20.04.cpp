#include <iostream>

using namespace std;

int countDivisors(int n) {
    int count = 0;
    for (int i = 1; i <= n; i++) {
        if (n % i == 0) {
            count++;
        }
    }
    return count;
}

int main() {
    int maxDivisors = 0;
    int maxNumber = 0;
    int n;
    do {
        cout << "Enter a positive integer (0 to exit): ";
        cin >> n;
        if (n != 0) {
            int divisors = countDivisors(n);
            cout << n << " has " << divisors << " divisors." << endl;
            if (divisors > maxDivisors) {
                maxDivisors = divisors;
                maxNumber = n;
            }
        }
    } while (n != 0);
    cout << "The number with the most divisors is " << maxNumber << " with " << maxDivisors << " divisors." << endl;
    return 0;
}
