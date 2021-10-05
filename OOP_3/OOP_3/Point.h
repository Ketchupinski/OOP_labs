#pragma once
#include <cmath>
#include <iostream>
#include <string> 
#include <sstream> 

using namespace std;

class Point
{
private:
	int x;
	int y;
	static int Count; // static field that count how much classes was created

public:
	Point(); // constructor

	static int getCount() { return Count; };
	int getX() const { return x; };
	int getY() const { return y; };
	void setX(int _x);
	void setY(int _y);
	friend double distanceToStartCoordinate(Point value); // friend func
	void toPolar(double& r, double& q);
	bool Init(int x, int y);
	void Read();
	void Display() const;
	string toString() const;
	static double PointToPoint(Point p1, Point p2); // static method
	friend void comprasionStartCordinate(Point p1, Point p2); // friend func
};

