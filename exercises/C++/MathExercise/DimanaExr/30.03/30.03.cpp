#include <iostream>

using namespace std;

void figuri(int a);
int main()
{
	int n;

	do {
		cin >> n;

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
		squares++;
		remain -= 4;
	}
	while (remain >= 3) // 2
	{
		triangles++;
		remain -= 3;
	}

	if (squares == 0 & triangles == 0 & remain == 1)
	{
		cout << "NO" << endl;
	}
	else {
		cout << squares << ' ' << triangles << endl;
	}

}
