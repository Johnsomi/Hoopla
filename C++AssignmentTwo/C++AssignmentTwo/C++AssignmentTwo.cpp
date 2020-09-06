// C++AssignmentTwo.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;

int main() {
	char choice;
	while (true) {

		int counter;

		char phoneNumber;

		cout << "\nEnter a phone number in letters only." << endl;

		for (counter = 0; counter < 7; counter++)
		{
			cin >> phoneNumber;

			if (counter == 3)
				cout << "-";

			if (phoneNumber >= 'A' && phoneNumber <= 'Z'
				|| phoneNumber >= 'a' && phoneNumber <= 'z')
				switch (phoneNumber)
				{
					case 'A':
					case 'a':
					case 'B':
					case 'b':
					case 'C':
					case 'c':
						cout << 2;
						break;
					case 'D':
					case 'd':
					case 'E':
					case 'e':
					case 'F':
					case 'f':
						cout << 3;
						break;
					case 'G':
					case 'g':
					case 'H':
					case 'h':
					case 'I':
					case 'i':
						cout << 4;
						break;
					case 'J':
					case 'j':
					case 'K':
					case 'k':
					case 'L':
					case 'l':
						cout << 5;
						break;
					case 'M':
					case 'm':
					case 'N':
					case 'n':
					case 'O':
					case 'o':
						cout << 6;
						break;
					case 'P':
					case 'p':
					case 'Q':
					case 'q':
					case 'R':
					case 'r':
					case 'S':
					case 's':
						cout << 7;
						break;
					case 'T':
					case 't':
					case 'U':
					case 'u':
					case 'V':
					case 'v':
						cout << 8;
						break;
					case 'W':
					case 'w':
					case 'X':
					case 'x':
					case 'Y':
					case 'y':
					case 'Z':
					case 'z':
						cout << 9;
						break;
				}
		}
		cout << "\nWould you like to perform other calculation?(Y/N)" << endl;
		cin >> choice;
		if (choice == 'Y' || choice == 'y') {
			return true;
		}
		else if (choice == 'N' || choice == 'n') {
			return false;
		}
	}
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
