#pragma once
#include <string>
#include <iostream>
using namespace std;

class Book
{
	private:
		string author;
		string name;
		string publisher;
		int year;
	public:
		void setName(string value);
		void setAuthor(string value);
		void setPublisher(string value);
		bool setYear(int value);
		string getName() const { return name; };
		string getAuthor() const { return author; };
		string getPublisher() const { return publisher; };
		int getYear() const { return year; };
		bool Init(string b_name, string auth, string publ, int y);
		void Read();
		void Display() const;
		bool CheckBook();


		
};

