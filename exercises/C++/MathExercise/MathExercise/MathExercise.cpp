#include <iostream>
using namespace std;

bool isPrime(int n) {
	if (n <= 1) {
		return false;
	}
	for (int i = 2; i * i <= n; i++) {
		if (n % i == 0 && n == i) {
			return false;
		}
	}
	return true;
}

int main() {
	int a, b;
	cout << "Enter two integers a and b (0 <= a < b): ";
	cin >> a >> b;

	bool foundPrime = false;
	for (int i = a; i <= b; i++) {
		if (isPrime(i)) {
			cout << i << " ";
			foundPrime = true;
		}
	}

	if (!foundPrime) {
		cout << "NO" << endl;
	}

	return 0;
}
