#include "Time.h"

int main() {
	Time t;
	Read(t);
	Display(t);
	cout << "In minutes: " << t.Minutes() << endl;


	cout << endl << endl
		<< "Overload:"
		<< endl << endl;

	Time a(20, 36);
	Time b(30, 42);

	cout << "1: a(20, 36)\n2: b(30, 42)" << endl << endl;
	Time c = a + b;
	cout << "a + b:\n" << string(c);
	Time z = b - a;
	cout << "b - a:\n" << string(z);
}