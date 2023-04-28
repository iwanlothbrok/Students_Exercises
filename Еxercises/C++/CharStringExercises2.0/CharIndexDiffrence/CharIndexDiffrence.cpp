#include <iostream>
#include <string>   
using namespace std;

int main() {
    string s1, s2;
    cout << "Enter the first string:";
    cin >> s1;
    cout << "Enter the second string:";
    cin >> s2;

    int n1 = s1.length();
    int n2 = s2.length();
    if (n1 != n2) {
        cout << "The two strings have different lengths." << endl;
        return 0;
    }

    cout << "The two strings have equal lengths." << endl;
    cout << "Difference by position:" << endl;
    for (int i = 0; i < n1; i++) {
        if (s1[i] != s2[i]) {
            cout << i + 1 << " " << s1[i] << "-" << s2[i] << endl;
        }
    }

    return 0;
}