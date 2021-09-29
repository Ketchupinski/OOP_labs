#include "Book.h"

Book makeBook(string author, string name, string publisher, int year)
{
	Book book;
	if (!book.Init(author, name, publisher, year))
	{
		cout << "You've inputed bad year!" << endl;
		exit(EXIT_FAILURE);
	}
	return book;
}


int main() {
	Book b;
	b.Read();
	b.Display();
	if (b.CheckBook()) {
		cout << endl;
		cout << "-------------------------------------------------------------------------------------" << endl;
		cout << "Yes, that's your book! :-)" << endl;
	}
	else {
		cout << endl;
		cout << "-------------------------------------------------------------------------------------" << endl;
		cout << "Sorry, but that's another book. :-(" << endl;
	}
	cout << "-------------------------------------------------------------------------------------" << endl << endl;

	cout << endl << endl << endl;

	cout << "Let's check another function:" << endl << endl << endl;
	cout << "Give me next information:" << endl << endl;
	string author, name, publisher;
	int year;
	cout << "Author: "; cin >> author;
	cout << "Book name: "; cin >> name;
	cout << "Book publisher: "; cin >> publisher;
	cout << "Year: "; cin >> year;
	b = makeBook(author, name, publisher, year);
	b.Display();
}

