#include <stdio.h>
#include <malloc.h>

struct sPerson
{
	int age;
	 struct Person *nextPerson;
};

int main()
{
	// creating person
	struct sPerson* person = NULL;
	
	// location the person 
	person = malloc(sizeof(struct sPerson));
	person->nextPerson = NULL;
	// setting age to the person
	person->age = 10;

	printf("%d", person->age);
}