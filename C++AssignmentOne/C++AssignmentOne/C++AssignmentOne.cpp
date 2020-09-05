// C++AssignmentOne.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>
using namespace std;


int main()
{
	ifstream inData;
	ofstream outData;
	string lastName = "";
	string firstName = "";
	double salary = 0;
	double raisePercentage = 0;
	double newSalary = 0;

	cout << fixed << setprecision(2);
	outData << fixed << setprecision(2);

	inData.open("Ch3_Ex5Data.txt");
	outData.open("Ch3_Ex5Output.txt");

	//employee 1
	cout << "Reading data from old file...\n\n";
	inData >> lastName >> firstName >> salary >> raisePercentage;
	newSalary = salary * ((1 + raisePercentage) / 100) + salary;
	cout << endl << firstName << " " << lastName << " has a new salary of $" << newSalary;
	outData << firstName << " " << lastName << " " << newSalary;

	//employee 2
	inData >> lastName >> firstName >> salary >> raisePercentage;
	newSalary = salary * ((1 + raisePercentage) / 100) + salary;
	cout << endl << firstName << " " << lastName << " has a new salary of $" << newSalary;
	outData << firstName << " " << lastName << " " << newSalary;

	//employee 3
	inData >> lastName >> firstName >> salary >> raisePercentage;
	newSalary = salary * ((1 + raisePercentage) / 100) + salary;
	cout << endl << firstName << " " << lastName << " has a new salary of $" << newSalary;
	cout << "\n\nWriting data to new file..." << endl << endl;
	outData << firstName << " " << lastName << " " << newSalary;

	inData.close();
	outData.close();

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
