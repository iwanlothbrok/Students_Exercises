#include <iostream>

bool is_prime(int n) {
    if (n < 2) {
        return false;
    }
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0) {
            return false;
        }
    }
    return true;
}

int main() {
    int count = 0;
    int n;
    do {
        std::cout << "Enter a positive integer (0 to stop): ";
        std::cin >> n;
        if (is_prime(n)) {
            count++;
        }
    } while (n != 0);
    std::cout << "Count of prime numbers entered: " << count << std::endl;
    return 0;
}
