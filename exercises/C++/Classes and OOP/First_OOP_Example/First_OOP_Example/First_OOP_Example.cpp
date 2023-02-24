

#include <iostream>
#include "People.h"

int main()
{
	People* p = new People("Iwan",12);

	cout << p->age << p->Name;
}
