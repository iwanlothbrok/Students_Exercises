//#include <stdio.h>
//
//void sort(char array[], int size)
//{
//    // bubble sort 
//    for (int i = 0; i < size - 1; i++)
//    {
//        for (int j = 0; j < size - i - 1; j++)
//        {
//            if (array[j] > array[j + 1])
//            {
//                int temp = array[j];
//                array[j] = array[j + 1];
//                array[j + 1] = temp;
//            }
//        }
//    }
//}
//
//void printArray(char array[], int size)
//{
//    for (int i = 0; i < size; i++)
//    {
//        printf("%c ", array[i]);
//    }
//}
//
//int main()
//{
//    //int array[] = {9, 1, 8, 2, 7, 3, 6, 4, 5};
//    char array[] = { 'F', 'A', 'D', 'B', 'C' };
//    int size = sizeof(array) / sizeof(array[0]);
//
//    sort(array, size);
//    printArray(array, size);
//
//    return 0;
//}
////////////////////// array of struct
#include <stdio.h>
#include <string.h>

struct Student
{
    char name[12];
    float gpa;
};

int main()
{
    struct Student student1 = { "Spongebob", 3.0 };
    struct Student student2 = { "Patrick", 2.5 };
    struct Student student3 = { "Sandy", 4.0 };
    struct Student student4 = { "Squidward", 2.0 };

    struct Student students[] = { student1, student2, student3, student4 };

    for (int i = 0; i < sizeof(students) / sizeof(students[0]); i++)
    {
        printf("name:%-12s\t", students[i].name);
        printf("gpa: %.2f\n", students[i].gpa);
    }

    return 0;
}