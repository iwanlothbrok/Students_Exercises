#include <stdio.h>
//
// WRITE IN FILE
//int main()
//{
//	// WRITE/APPEND A FILE
//	//FILE* pF;
//	//fopen_s(&pF, "test.txt", "w");
//
//	//fprintf(pF, "Spongebob Squarepants");
//
//	//fclose(pF);
//
//	 //DELETE A FILE
//	
//	if(remove("test.txt") == 0)
//	{
//	   printf("That file was deleted successfully!");
//	}
//	else
//	{
//	   printf("That file was NOT deleted!");
//	}
//	
//	return 0;
//}
///////////////////////////////////////////////////////
//READ
int main()
{
    FILE* pF = fopen("poem.txt", "r");
    char buffer[255];

    if (pF == NULL)
    {
        printf("Unable to open file!\n");
    }
    else
    {
        while (fgets(buffer, 255, pF) != NULL)
        {
            printf("%s", buffer);
        }
    }

    fclose(pF);

    return 0;
}