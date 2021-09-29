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


public:
	int getX() const { return x; };
	int getY() const { return y; };
	void setX(int _x);
	void setY(int _y);
	double distanceToStartCoordinate()  const;
	void toPolar(double& r, double& q);
	bool Init(int x, int y);
	void Read();
	void Display() const;
	string toString() const;
	double distanceToPoint(Point point)  const;
	void comprasionStartCordinate(Point point) const;
};
