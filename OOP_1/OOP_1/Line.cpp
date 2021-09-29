#include "Line.h"


bool Line::Init(int x, int y)
{
    if (x != 0)
    {
        first = x;
        second = y;
        return true;
    }
    else
    {
        return false;
    }
}
void Line::Read()
{
    double A, B;
    do
    {
        cout << "Please, throw me some numbers:" << endl;
        cout << " A = "; cin >> A;
        cout << " B = "; cin >> B;
    } while (!Init(A, B));
}
void Line::Display() const
{
    cout << endl;
    cout << "----------------------------------------------------------" << endl;
    cout << "You've inputed: " << endl;
    cout << " A = " << first << endl;
    cout << " B = " << second << endl;
    cout << "----------------------------------------------------------" << endl;
    cout << endl;
}


double Line::Function()
{
   
    return second * (-1) / first;
}

