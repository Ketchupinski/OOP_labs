/*
* Створити клас Point для роботи з точками на площині. Координати точки –
декартові. Поля:
• x
• y
Обов’язково мають бути реалізовані:
• перетворення у полярні координати,
• визначення відстані до початку координат,
• порівняння на рівність та нерівність
*/



#include "Point.h"

Point makePoint(int x, int y)
{
	Point p;
	if (!p.Init(x, y))
	{
		cout << "Oops, something gone wrong!" << endl; // unreal situation??
		exit(EXIT_FAILURE); 
	}
	return p;
}


int main() {
	cout << "First point:" << endl;
	Point first;
	first.Read();
	first.Display();
	
	double r = 0, q = 0;
	first.toPolar(r, q);
	cout << endl << 
		"Polar cordinates:\nr: " << r << "\nq: " << q 
		<< endl << endl;

	cout << "Second point:" << endl << endl;
	Point second;
	int x, y;
	cout << "Throw me \'x\': "; cin >> x;
	cout << "Throw me \'y\': "; cin >> y;
	second = makePoint(x, y);


	cout << endl << endl;
	cout << "You've inputed next information:" << endl << second.toString() << endl;

	cout << endl << endl;
	cout << "Distance from first point(" << first.getX() << ";" << first.getY()
		<< ") to second point(" << second.getX() << ";" << second.getY() << "): "
		<< Point::PointToPoint(first, second) << endl << endl << endl; // use static method

	cout << "Distance from first point to (0;0): " << distanceToStartCoordinate(first) << endl << endl; // friend func
	cout << "Distance from second point to (0;0): " << distanceToStartCoordinate(second) << endl; // friend func

	comprasionStartCordinate(first, second);

	cout << endl << endl <<
		"Points created: " << Point::getCount() // print static field
		<< endl; 
}

