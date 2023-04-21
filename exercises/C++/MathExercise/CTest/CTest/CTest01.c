

/// <summary>
/// FOR PRINTING LONG => %ld 
/// Символна константа и низова константа, съдържащи един-единствен символ: 'х' не е същото като "х". 
///'х' представлява цяло число, използвано за представяне на числовата стойност на буквата х в кодовата таблица на компютъра.
///"х" представлява масив от символи, който съдържа само един символ(буквата х) и '\0' накрая.
/// </summary>



//
//void main() {
//	printf("Hello\n");
//	system("pause");
//
//	char greetings[] = { 'H','i','\0' };
//}



/// <summary>
/// GETTING EVERY CHAR FROM CHAR[]
///EOF => С употребата на тази символна константа ние сме сигурни, че нищо в програмата не зависи от точно определена числена стойност.
/// </summary>
//void main() {
//
//	int c;
//	c = getchar();
//	while (c != EOF){
//		putchar(c);
//		c = getchar();
//	}
//}


//----------------------------
//void main() {
//	int i, c, nwhite, nother;
//	int ndigit[10];
//
//	nwhite = nother = 0;
//
//	for (i = 0; i < 10; i++)
//	{
//		ndigit[i] = 0;
//
//		while ((c = getchar()) != EOF)
//		{
//			if (c>= '0' && c <= '9')
//			{
//				++ndigit[c-'0']; // check whats this
//			}
//			else if (c == ' ' || c == '/n' || c == 't')
//			{
//				nwhite++;
//			}
//			else
//			{
//				nother++;
//			}
//		}
//	}
//
//	printf("digits =");
//	for (i = 0; i < 10; i++)
//	{
//		printf(" %d", ndigit[i]);
//	}
//	printf(", white space = %d, other = %d", nwhite, nother);
//}

//Напишете програма, която отпечатва входа си, като всяка дума е поставена на отделен ред.
//
//#include <stdio.h>
//
//int main() {
//    char c;
//    while ((c = getchar()) != EOF) {
//        putchar(c);
//        if (c == ' ' || c == '\t' || c == '\n') {
//            putchar('\n');
//        }
//    }
//
//    return 0;
//}

#include <stdio.h>

#define MAX_SIZE 100 // Maximum size of the array

int main()
{
    int arr[MAX_SIZE], size, i, pos, value;

    // Get the size of the array from the user
    printf("Enter size of the array: ");
    scanf("%d", &size);

    // Get elements from the console and store them in the array
    printf("Enter elements of the array:\n");
    for (i = 0; i < size; i++)
    {
        scanf("%d", &arr[i]);
    }

    // Print the original array
    printf("Original array: ");
    for (i = 0; i < size; i++)
    {
        printf("%d ", arr[i]);
    }

    // Reverse the array
    printf("\nReversed array: ");
    for (i = size - 1; i >= 0; i--)
    {
        printf("%d ", arr[i]);
    }

    // Remove an element from the array
    printf("\nEnter the position of the element to be removed: ");
    scanf("%d", &pos);

    if (pos < 0 || pos >= size)
    {
        printf("Invalid position!\n");
    }
    else
    {
        for (i = pos; i < size - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        size--;

        // Print the updated array
        printf("Updated array: ");
        for (i = 0; i < size; i++)
        {
            printf("%d ", arr[i]);
        }
    }

    // Add an element to the array
    printf("\nEnter the position where you want to insert an element: ");
    scanf("%d", &pos);
    printf("Enter the value to be inserted: ");
    scanf("%d", &value);

    if (pos < 0 || pos > size)
    {
        printf("Invalid position!\n");
    }
    else
    {
        for (i = size; i > pos; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[pos] = value;
        size++;

        // Print the updated array
        printf("Updated array: ");
        for (i = 0; i < size; i++)
        {
            printf("%d ", arr[i]);
        }
    }

    return 0;
}
