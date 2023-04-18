//#include <stdio.h>
//
//int main() {
//    char name[20];
//
//    printf("What is your name?\n");
//    scanf_s("%s", name, sizeof(name));
//
//    printf("Hello, %s! Nice to meet you.\n", name);
//
//    return 0;
//}


#include <stdio.h>

int main() {
    int number;

    printf("Please enter a number: ");
    scanf_s("%d", &number);

    int sum = 0;
    int currentNumber;
    for (int i = 0; i < number; i++)
    {
        scanf_s("%d", &currentNumber);

        sum += currentNumber;
    }

    printf("The number you entered is: %d\n", number);
    printf("Your sum is %d\n", sum);

    return 0;
}


//1. Изчисляваме натрупаната лихва : 200 * 0.057 (5.7 %) = 11.40 лв.
//2. Изчисляваме лихвата за 1 месец : 11.40 лв. / 12 месеца = 0.95 лв.
//3. Общата сума е : 200 лв. + 3 * 0.95 лв. = 202.85 лв.
