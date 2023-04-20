#include <iostream>

void print_divisors(int n) {
    std::cout << "Divisors of " << n << ": ";
    for (int i = 1; i <= n; i++) {
        if (n % i == 0) {
            std::cout << i << " ";
        }
    }
    std::cout << std::endl;
}

int main() {
    int n;
    std::cout << "Enter a natural number N: ";
    std::cin >> n;
    std::cout << "Enter " << n << " positive integers: ";
    for (int i = 0; i < n; i++) {
        int x;
        std::cin >> x;
        print_divisors(x);
    }
    return 0;
}
