	#include <iostream>
	using namespace std;

	struct elem {
		int key;
		elem* next;
	};

	elem* start1 = NULL;
	elem* start2 = NULL;
	void push1(int n) {
		elem* p1 = start1;
		start1 = new elem;
		start1->key = n;
		start1->next = p1;
	}

	void push2(int n) {
		elem* p2 = start2;
		start2 = new elem;
		start2->key = n;
		start2->next = p2;
	}

	bool pop1(int& n) {
		if (start1 == NULL) return false;
		else {
			n = start1->key;
			elem* p1 = start1;
			start1 = start1->next;
			delete p1; p1 = NULL;
			return true;
		}
	}

	bool pop2(int& n) {
		if (start2 == NULL) return false;
		else {
			n = start2->key;
			elem* p2 = start2;
			start2 = start2->next;
			delete p2; p2 = NULL;
			return true;
		}
	}

	int main() {
		int num;
		cout << "Imput int:\n";

		while (cin >> num) {
			if (num == 0)break;
			if(num%2==0)push1(num);
			else push2(num);
		}

		cout << "\nStack:\n";

		cout << "Chetni\n";
		while (pop1(num)) {
			cout << num << " ";
		}
		cout << endl;
		cout << "Nechetni\n";
		while (pop2(num)) {
			cout << num << " ";
		}

		return 0;
	}


