// $"" in C
#include <stdio.h>
#include <string>

struct  Student
{
	int age;
	char name[50];
};

void main()
{
	// .01
	//char name[] = "Iwcho";
	// printf("Hello my name is %s\n", name); working correctly 

	// .02
	//char name[20];
	//fgets(name,20,stdin); // stdin e rawno na console
	//// John (Smith) i familiqta se zapiswa 

	//printf("%s",name);

	// .03 struct
	struct Student s1;
	s1.age = 10;
	// s1.name = "Gogo"; -- > ne raboti 
	strcpy(s1.name, "Gogo"); // raboti

	system("pause");
}