#include "Book.h"

void Book::setName(string value) {
	name = value;
}

void Book::setAuthor(string value) {
	author = value;
}

void Book::setPublisher(string value) {
	publisher = value;
}

bool Book::setYear(int value) {
	if (value > 0) {
		year = value;
		return true;
	}
	else {
		year = 0;
		return false;
	}
}

bool Book::Init(string b_name, string auth, string publ, int y)
{
	setName(b_name);
	setAuthor(auth);
	setPublisher(publ);
	return setYear(y);
}

void Book::Read()
{
	string b_name;
	string auth;
	string publ;
	int y;
	cout << endl;
	cout << "Book name: "; cin >> b_name;
	cout << "Author: "; cin >> auth;
	cout << "Publisher: "; cin >> publ;
	do
	{
		cout << "Year: "; cin >> y;
	} while (!Init(b_name, auth, publ, y));
}

void Book::Display() const
{
	cout << endl << endl;
	cout << "===================================================================================" << endl << endl;
	cout << "You've inputed next information:" << endl << endl;
	cout << "Book name: " << name << endl;
	cout << "Author: " << author << endl;
	cout << "Publisher: " << publisher << endl;
	cout << "Year: " << year << endl << endl;
	cout << "===================================================================================" << endl << endl;
}

bool Book::CheckBook() {
	string b_name;
	string auth;
	string publ;
	int y;
	cout << "-------------------------------------------------------------------------------------" << endl;
	cout << "Let's check is it your book!" << endl;
	cout << "-------------------------------------------------------------------------------------" << endl << endl;
	cout << "Book name: "; cin >> b_name;
	if (b_name == name) {
		cout << "Author: "; cin >> auth;
		if (auth == author) {
			cout << "Publisher: "; cin >> publ;
			if (publ == publisher) {
				cout << "Year: "; cin >> y;
				if (y == year) {
					return true;
				}
			}
		}
	}
	return false;
}
