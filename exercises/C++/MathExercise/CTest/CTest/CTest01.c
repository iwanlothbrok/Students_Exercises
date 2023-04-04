#include <stdio.h>

void main() {
	printf("Hello\n");
	system("pause");

	char greetings[] = { 'H','i','\0' };
	//In your example, the character array "greetings" is being used to store the string "Hi".
	//	By adding the null terminator '\0' at the end of the string, you are indicating to the compiler that 
	//	this is the end of the string.This is important because C functions that work with strings
	//	, such as strlen() or strcmp(), use the null terminator to determine the length of the stringand 
	//	when to stop processing it.

	//	If you forget to add the null terminator at the end of a string,
	//	C functions that work with strings will continue reading past the end of the
	//	array, resulting in undefined behavior, such as a segmentation fault or unexpected
	//	program behavio
}