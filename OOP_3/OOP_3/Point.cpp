#include "Point.h"


void Point::setX(int _x) 
{
	x = _x;
}

void Point::setY(int _y) 
{
	y = _y;
}


double Point::distanceToStartCoordinate()  const
{
    return sqrt((x * x) + (y * y)); // work good
}

void Point::toPolar(double& r, double& q) {
	r = sqrt(x * x + y * y); q = atan(y / x); // work good
}

bool Point::Init(int x, int y)
{
	setX(x);
	setY(y);
	return (x != NULL && y != NULL);
}

void Point::Read()
{
	int x;
	int y;
	cout << endl;
	do
	{
		cout << "x: "; cin >> x;
		cout << "y: "; cin >> y;
	} while (!Init(x, y));
}

void Point::Display() const
{
	cout << endl << endl;
	cout << "===================================================================================" << endl << endl;
	cout << "You've inputed next information:" << endl << endl;
	cout << "x: " << x << endl;
	cout << "y: " << y << endl << endl;
	cout << "===================================================================================" << endl << endl;
}

/*
string Point::toStr() const
{
	stringstream sout;
	sout << "x = " << x << endl; 
	sout << "y = " << y << endl; 
	return sout.str(); 
}
*/

double Point::distanceToPoint(Point point)  const // work good
{
	return sqrt(pow(point.getX() - x, 2)
		+
		pow(point.getY() - y, 2) );
}

void Point::comprasionStartCordinate(Point point) const
{
	double first_dist = distanceToStartCoordinate();
	double second_dist = point.distanceToStartCoordinate();
	cout << endl << endl;
	if (first_dist > second_dist) {
		cout << "The first point is " << first_dist - second_dist << " farther from the start of cordinate than second!" << endl;
	}
	if (second_dist > first_dist) {
		cout << "The second point is " << second_dist - first_dist << " farther from the start of cordinate than first!" << endl;
	}
	if (first_dist == second_dist) {
		cout << "The first and second points are equally far from the start of cordinate: " << first_dist << endl;
	}

}

string Point::toString() const {
	stringstream sout; 
	sout << "x = " << x << endl;
	sout << "y = " << y << endl;
	return sout.str(); 
}