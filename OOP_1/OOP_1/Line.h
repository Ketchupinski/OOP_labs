#pragma once

#include <iostream>

using namespace std;

class Line
{
	private:
		double first, second;
	public:
		bool Init(int, int);
		void Read();
		double Function();
		void Display() const;
};

