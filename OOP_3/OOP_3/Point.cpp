#include "Point.h"

int Point::Count = 0; // initialize static field 

Point::Point() {
	this->x = 0;
	this->y = 0;
	Count++; // count objects
}

void Point::setX(int _x) 
{
	x = _x;
}

void Point::setY(int _y) 
{
	y = _y;
}


double distanceToStartCoordinate(Point value) // friend function
{
    return sqrt((value.x * value.x) + (value.y * value.y)); 
}

void Point::toPolar(double& r, double& q) {
	r = sqrt(x * x + y * y);
	if (x == 0) {
		q = 0;
	}
	else {
		q = atan(y / x);
	}
}

bool Point::Init(int x, int y)
{
	setX(x);
	setY(y);
	return true;
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
 
double Point::PointToPoint(Point p1, Point p2) {
	return sqrt(pow(p2.getX() - p1.getX(), 2)
		+
		pow(p2.getY() - p1.getY(), 2));
}

void comprasionStartCordinate(Point p1, Point p2) // friend func
{
	double first_dist = distanceToStartCoordinate(p1); // friend func at friend func :)
	double second_dist = distanceToStartCoordinate(p2);
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