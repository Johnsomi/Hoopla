// C++Assignment3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;

void taxOfMaried();
void single();

int main()
{
	char status;
	int choice;
	do
	{
		cout << "Enter your Martial Status ('m' for married 's' for single): ";
		cin >> status;
		if (status == 'm' || status == 'M')
			taxOfMaried();
		else if (status == 's' || status == 'S')
			single();
		else
			cout << "Invalid Input." << endl;

		cout << "\n Enter 1 to re-run: ";
		cin >> choice;
	} while (choice == 1);

	system("pause");
	return 0;
}

void taxOfMaried()
{
	int exemption = 7000;
	int salary, wifesalary, numchild, totalsalary, tempsalary;
	float tax, pention;

	cout << "Ener the salary of your spouse: ";
	cin >> wifesalary;
	cout << "Enter your salary: ";
	cin >> salary;
	cout << "Enter the number of child of age under age 14: ";
	cin >> numchild;

	totalsalary = salary + wifesalary;

	if (numchild == 2)
		exemption = exemption * 4;

	cout << "Your Exemption is: " << exemption << endl;
	tempsalary = totalsalary;
	tempsalary = tempsalary - exemption;

	if (tempsalary <= 15000)
		tax = tempsalary * (15.0 / 100.0);
	else if (tempsalary <= 40000)
		tax = 2250 + (tempsalary * (25.0 / 100.0));
	else
		tax = 8460 + (tempsalary * (35.0 / 100.0));

	pention = totalsalary * (6.0 / 100.0);
	tax = tax + pention;

	cout << "Your total tax on salary (including pention):" << totalsalary << endl;
	cout << "Your remaining salary is: " << tempsalary - tax - exemption << endl;
}

void single()
{
	int exemption = 4000;
	float tax, pention;
	int salary, tempsalary;
	cout << "Enter your salary: ";
	cin >> salary;
	tempsalary = salary;
	tempsalary = tempsalary - exemption;

	if (tempsalary <= 15000)
		tax = tempsalary * (15.0 / 100.0);
	else if (tempsalary <= 40000)
		tax = 2250 + tempsalary * (25.0 / 100.0);
	else
		tax = 8460 + tempsalary * (35.0 / 100.0);

	cout << "Your exemption is: " << exemption << endl;

	pention = salary * (6.0 / 100.0);
	cout << "Your tax without pention fund is: " << tax << endl;
	cout << "Your salary after including pention: " << tax + pention << endl;
	cout << "Your salary after paying tax: " << salary - exemption - tax - pention << endl;
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
