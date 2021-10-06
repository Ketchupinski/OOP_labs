#include "Complex.h"

using namespace std;

int main() {
	Complex num;
	Complex a, b;
	cin >> a;
	cout << endl << endl;
	cin >> b;
	cout << endl << endl;

	//print overloads
	Complex x;

	x = a + b;
	cout << "a + b:" << x;

	x = a - b;
	cout << "a - b:" << x;

	x = a * b;
	cout << "a * b:" << x;

	x = a / b;
	cout << "a / b:" << x;

	x = a += b;
	cout << "a += b:" << x;

	x = a -= b;
	cout << "a -= b:" << x;

	x = a *= b;
	cout << "a *= b:" << x;

	x = a /= b;
	cout << "a /= b:" << x;

}