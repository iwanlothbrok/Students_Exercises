#pragma once
class TFibonacci
{
	int Fib1;
	int Fib2;
public:
	TFibonacci() : Fib1(1), Fib2(1){}

	int NextNumber() {

		int res =  Fib1 + Fib2;

		Fib1 = Fib2;
		Fib2 = res;

		return res;
	}
};

