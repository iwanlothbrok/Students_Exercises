#include <stdio.h>

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

