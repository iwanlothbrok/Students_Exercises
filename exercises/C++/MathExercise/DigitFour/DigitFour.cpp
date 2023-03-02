#include <iostream>

bool hasDigitFour(int n) {
    while (n != 0) {
        int digit = n % 10;
        if (digit == 4) {
            return true;
        }
        n /= 10;
    }
    return false;
}

int main() {
    int a, b;
    std::cin >> a >> b;
    bool found = false;
    for (int i = a; i <= b; i++) {
        if (hasDigitFour(i)) {
            std::cout << i << " ";
            found = true;
        }
    }
    if (!found) {
        std::cout << "NO";
    }
    std::cout << std::endl;
    return 0;
}