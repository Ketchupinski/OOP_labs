#include "Time.h"

Time::Time() {
	this->first = 0;
	this->second = 0;
}

Time::Time(int _first, int _second) {
	int extra_hours = 0; 
	int rest = 0;

	// first
	if (_first >= 0 && _first < 60) {
		this->first = _first;
	}
	else if (_first >= 60) {
		extra_hours = _first / 60;
		rest = _first - (extra_hours * 60); // minutes to hours
		this->first = rest;
	}
	else {
		this->first = 0;
	}

	// second  
	if (_second + extra_hours >= 0) {
		this->second = _second + extra_hours; 
	}
	else {
		this->second = 0;
	}
}

Time::Time(const Time& other) {
	this->first = other.first;
	this->second = other.second;
}

Time::~Time() { // destructor just set all fields to zero
	first = 0;
	second = 0;
}


Time::operator string () const {
	stringstream stream;
	stream << " First = " << first << endl;
	stream << " Second = " << second << endl;
	return stream.str();
}


void Time::setFirst(int first) {
	this->first = first;
}

void Time::setSecond(int second) {
	this->second = second;
}

void Display(Time value) { // friend func 
	cout << endl << endl << "====================================================================================" << endl << endl;
	cout << "You've inputed next time: " << value.second << ":" << value.first << endl;
	cout << endl << "====================================================================================" << endl << endl;
}

void Read(Time& value) { // friend func
	int min, hour;
	cout << "Please, input hour: "; cin >> hour;
	cout << "Please, input min: "; cin >> min;
	Time f(min, hour);
	value = f;
}


int Time::Minutes() const {
	return this->second * 60 + this->first;
}




// Overload operators ???

Time operator + (const Time& f, const Time& s) {
	return Time(f.first + s.first, f.second + s.second);
}

Time operator - (const Time& f, const Time& s) {
	return Time(f.first - s.first, f.second - s.second);
}

Time operator * (const Time& f, const Time& s) {
	return Time(s.first * f.first - s.second * f.second,
				s.first * f.second + s.second * f.first);
}

Time operator / (const Time& f, const Time& s)
{
	double r1 = f.first;
	double i1 = f.second;
	double r2 = s.first;
	double i2 = s.second;
	return Time((r1 * r2 - i1 * i2) / (r2 * r2 + i2 * i2),
		(-r1 * i2 + i1 * r2) / (r2 * r2 + i2 * i2));
}
Time operator ^ (const Time& f, unsigned int n)
{
	Time s(1, 0);
	for (unsigned int i = 1; i <= n; i++)
		s = s * f;
	return s;
}