#include "Line.h"

Line makeLine(int A, int B)
{
	Line line;
	if (!line.Init(A, B))
	{
		cout << "This function has no root!" << endl;
		exit(EXIT_FAILURE);
	}
	return line;
}

int main()
{
	Line line;
	line.Read();
	line.Display();
	cout << "Root of function y = Ax + B: " << line.Function() << endl << endl;
	double A, B;
	cout << endl << endl;
	cout << "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" << endl;
	cout << endl << endl;
	cout << "Throw some numbers:" << endl << endl;
	cout << " A = "; cin >> A;
	cout << " B = "; cin >> B;
	line = makeLine(A, B);
	line.Display();
	cout << "Root of function y = Ax + B: " << line.Function() << endl << endl;
	cin.get();
	return 0;
}

