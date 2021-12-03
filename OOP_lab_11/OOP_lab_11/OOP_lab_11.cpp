#include "B1.h"
#include "B2.h"
#include "D1.h"
#include "D2.h"
#include "D3.h"

int main()
{
	B1 o0(777);
	cout << "B o0(777);" << endl;
	cout << "sizeof(B) = " << sizeof(B1) << endl;
	cout << endl << "Class hierarchy B: " << endl;
	o0.show_B1();

	D1 o1(111, 222);
	cout << "D1 o1(111, 222);" << endl;
	cout << "sizeof(D1) = " << sizeof(D1) << endl;
	cout << endl << "Class hierarchy D1: " << endl;
	o1.show_D1();

	B2 o2(22);
	cout << "B2 o2(22);" << endl;
	cout << "sizeof(D1) = " << sizeof(D1) << endl;
	cout << endl << "Class hierarchy B2: " << endl;
	o2.show_B2();
		
	D2 o3(1000, 2000, 3000, 4000);
	cout << "D2 o3(1000, 2000, 3000, 4000);" << endl;
	cout << "sizeof(D2) = " << sizeof(D2) << endl;
	cout << endl << "Class hierarchy D2: " << endl;
	o3.show_D2();


	D3 o4(100, 200, 300, 400, 500);
	cout << "D3 o3(100, 200, 300, 400, 500);" << endl;
	cout << "sizeof(D3) = " << sizeof(D3) << endl;
	cout << endl << "Class hierarchy D3: " << endl;
	o4.show_D3();
}
