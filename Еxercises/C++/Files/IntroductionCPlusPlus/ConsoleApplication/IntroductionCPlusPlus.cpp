#include <iostream>
using namespace std;

struct Person {
private:
    string name;
    int age;
    string gender; 

public:
    void SetName(){

    }
};

void printArr(char* arr);

int main()
{
    char someCharArr[50] = "this is some char arr";

    printArr(someCharArr);

    //// Print
    //cout << "Hello World!";

    //// Print on new row
    //cout << 1 << endl;

    //// Print multiple elements in new rows
    //cout << 1 << endl << 2 << endl << 3 << endl;

    //// Initialize variables
    //string firstName, someText, lastName;

    //// Variables
    //int number = 1;
    //double grade = 4.5;
    //string text = "Hello";
    //char symbol = '&';
    //bool isValid = true;

    //// Life of variable - scope {}

    //// Read from console
    //string name;
    //cin >> name;
    //cin >> firstName >> someText >> lastName;

    //// Print with variables
    //cout << "Hello, " << firstName << " " << lastName;

    //// Simple Math Operators - (+ - * / %)
    //
    //// Logical Operator - (&& || !)

    //// Operators for comperison 
    //// Равенство ==
    //// Различно !=
    //// По-голямо >
    //// По-голямо или равно >=
    //// По-малко <
    //// По-малко или равно <=

    //// 
    //int a = 5;
    //int b = 10;
    //cout << (a < b) << endl;
    //cout << (a > 0) << endl;
    //cout << (a > 100) << endl;
    //cout << (a < a) << endl;
    //cout << (a <= 5) << endl;
    //cout << (b == 2 * a) << endl;

    //string f = "Example";
    //string d = f;
    //cout << (a == b) << endl;

    //string r, t;
    //cin >> r >> t;
    //cout << (r == t) << endl;

    //bool isREqualToD = r == t;

    //// Simple varifications
    //if (true) // ---- условие (булев израз)
    //{
    //    // код за изпълнение при вярно условие
    //}

    //// При невярност на условието може да изпълним други действия
    //// чрез else конструкция

    //if (true)
    //{
    //    // код за изпълнение при вярно условие
    //}
    //else {
    //    // код за изпълнение при грешно условие
    //}

    //// закръгляне на числа 
    //// ceil()
    //// floor()

    //// Фиксиране на изходните числа 
    //cout.setf(ios::fixed);
    //cout.precision(2);

    //// switch - case

    //// if, else if, else if, else

    //// End program
    return 0;
}

void printArr(char* arr) {
    while (*arr != '\0') {
        cout << *arr;
        arr++;
    }
}