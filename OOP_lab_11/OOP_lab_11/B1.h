#pragma once
#include <iostream>

using namespace std;

class B1
{
	int b1;
public:
	B1(int x)
	{
		b1 = x;
	}

	void show_B1()
	{
		cout << "class B1:" << endl;
		cout << "show_B1()" << endl
			<< "B1::b1 = " << b1 << endl << endl;
	}
};

