#pragma once
#include <iostream>
#include <sstream>

using namespace std;

class Time {
private: 
	int first; // minutes
	int second; // hours

public:
	//constructors
	Time();
	Time(int, int);
	Time(const Time&);

	//destructor
	~Time();

	//overload
	operator string() const;
	friend Time operator + (const Time&, const Time&);
	friend Time operator - (const Time&, const Time&);
	friend Time operator * (const Time&, const Time&);
	friend Time operator / (const Time&, const Time&);
	friend Time operator ^ (const Time&, const unsigned);

	//other methods
	int getFirst() const { return first; };
	int getSecond() const { return second; };
	void setFirst(int first);
	void setSecond(int second);
	friend void Display(Time value);
	friend void Read(Time& value);
	int Minutes() const;

};