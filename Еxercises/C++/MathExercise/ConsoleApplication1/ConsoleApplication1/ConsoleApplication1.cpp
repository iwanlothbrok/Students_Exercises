#include <iostream>

using namespace std;

void figuri(int a);
int main()
{
	int n;

	do {
		cin >> n;

		if (n == 0)
		{
			return 0;
		}
		figuri(n);
	} while (n != 0);

	return 0;
}
void figuri(int a)
{
	int squares = 0;
	int triangles = 0;


	int remain = a;

	while (remain >= 4) {
		if (remain == 3 || remain == 6 || remain == 9)
		{
			break;
		}
		squares++;
		remain -= 4;
	}
	while (remain >= 3) // 2
	{
		triangles++;
		remain -= 3;
	}

	if (remain != 0)
	{
		cout << "NO" << endl;
	}
	else {
		cout << squares << ' ' << triangles << endl;
	}

}