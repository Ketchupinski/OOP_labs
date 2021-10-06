#pragma once
#include <iostream>
#include <string>
#include <sstream>

using namespace std;

class Complex
{
	double real; // real part of complex number
	double image; // image part of complex number
public:
	// constructors
	Complex();
	Complex(double, double);
	Complex(const Complex&);
	
	//destructor
	~Complex();

	//setter/getters
	void SetReal(double);
	void SetImage(double);
	double GetReal() const;
	double GetImage() const;

	//overload
	Complex& operator = (const Complex&);
	operator string() const;
	friend Complex operator + (const Complex&, const Complex&);
	friend Complex operator - (const Complex&, const Complex&);
	friend Complex operator * (const Complex&, const Complex&);
	friend Complex operator / (const Complex&, const Complex&);
	friend Complex operator ^ (const Complex&, const unsigned);
	friend Complex operator += (const Complex& x, const Complex& y);
	friend Complex operator *= (const Complex& x, const Complex& y);
	friend Complex operator -= (const Complex& x, const Complex& y);
	friend Complex operator /= (const Complex& x, const Complex& y);
	friend ostream& operator << (ostream&, const Complex&);
	friend istream& operator >> (istream&, Complex&);
	friend bool operator==(const Complex& x, const Complex& y);
	Complex& operator ++();
	Complex& operator --();
	Complex operator ++(int);
	Complex operator --(int); 
};