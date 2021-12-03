#pragma once

#include "D1.h"
#include "B2.h"

class D2 : private D1, private B2 {
	int d2;
public:
	D2(int x, int y, int z, int i)
		: D1(y, z), B2(i)
	{
		d2 = x;
	}
	void show_D2()
	{
		cout << "class D2:" << endl;
		show_D1();
		show_B2();
		cout << "show_D2()" << endl
			<< "D2::d2 = " << d2 << endl << endl;
	}
};

