using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook gradebook = new Gradebook();
            //set up optionsArray
            string[] options = new string[14];
            options[0] = "change section";
            options[1] = "add section";
            options[2] = "add student";
            options[3] = "add assignment to student";
            options[4] = "add assignment to section";
            options[5] = "set score";
            options[6] = "mark tardy";
            options[7] = "mark absent";
            options[8] = "get overall score";
            options[9] = "get overall score avg";
            options[10] = "get assignment score";
            options[11] = "get assignment score avg";
            options[12] = "get tardy count";
            options[13] = "get absent count";


            //main loop to get input:
            while (true)
            {
                //print options
                Console.WriteLine("Type one of the following commands:");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(options[i]);
                }
                string input = Console.ReadLine();
                //find out which option the selected
                int optionSelectIndex;
                for (optionSelectIndex = 0; optionSelectIndex < options.Length; optionSelectIndex++)
                {
                    if (options[optionSelectIndex].Equals(input))
                    {
                        break;
                    }
                }

                bool retBool = false;
                double retDouble = -1;
                if (optionSelectIndex == 0)
                {
                    Console.WriteLine("Enter a section name");
                    string sectionName = Console.ReadLine();
                    retBool = gradebook.changeSection(sectionName);
                }
                else if (optionSelectIndex == 1)
                {
                    Console.WriteLine("Enter a section name");
                    string sectionName = Console.ReadLine();
                    retBool = gradebook.addSection(sectionName);
                }
                else if (optionSelectIndex == 2)
                {
                    Console.WriteLine("Enter student first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter student last name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    long phoneNumber = getPhoneNumber();
                    retBool = gradebook.addStudent(firstName, lastName, userName, phoneNumber);
                }
                else if (optionSelectIndex == 3)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter assignment name:");
                    string assignmentName = Console.ReadLine();
                    int ptsPossible = getUInt();
                    retBool = gradebook.addAssignmentToStudent(userName, assignmentName, ptsPossible);
                }
                else if (optionSelectIndex == 4)
                {
                    Console.WriteLine("Enter assignment name:");
                    string assignmentName = Console.ReadLine();
                    int ptsPossible = getUInt();
                    retBool = gradebook.addAssignmentToSection(assignmentName, ptsPossible);
                }
                else if (optionSelectIndex == 5)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter assignment name:");
                    string assignmentName = Console.ReadLine();
                    int ptsEarned = getUInt();
                    retBool = gradebook.setScore(userName, assignmentName, ptsEarned);
                }
                else if (optionSelectIndex == 6)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    retBool = gradebook.markTardy(userName);
                }
                else if (optionSelectIndex == 7)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    retBool = gradebook.markAbsent(userName);
                }
                else if (optionSelectIndex == 8)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    retDouble = gradebook.getOverallScore(userName);
                }
                else if (optionSelectIndex == 9)
                {
                    retDouble = gradebook.getOverallScoreAvg();
                }
                else if (optionSelectIndex == 10)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter assignment name:");
                    string assignmentName = Console.ReadLine();
                    retDouble = gradebook.getAssignmentScorePercent(userName, assignmentName);
                }
                else if (optionSelectIndex == 11)
                {
                    Console.WriteLine("Enter assignment name:");
                    string assignmentName = Console.ReadLine();
                    retDouble = gradebook.getAssignmentScoreAvg(assignmentName);
                }
                else if (optionSelectIndex == 12)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    retDouble = gradebook.getTardyCount(userName);
                }
                else if (optionSelectIndex == 13)
                {
                    Console.WriteLine("Enter student username:");
                    string userName = Console.ReadLine();
                    retDouble = gradebook.getAbsentCount(userName);
                }
                else
                {
                    Console.WriteLine("not a valid option");
                    continue;
                }
                if (retBool)
                {
                    Console.WriteLine("action completed successfully");
                }
                else if (retDouble != -1)
                {
                    Console.WriteLine("Result from command: " + retDouble);
                }
                else
                {
                    Console.WriteLine("There was an error with the command, operation not completed");
                }
            }

        }
        static long getPhoneNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("enter a phone number including area code as a 10 digit number");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine());
                    if (phoneNumber < 1000000000L || phoneNumber > 9999999999L)
                    {
                        Console.WriteLine("not a valid phone number enter a number including area code without space or - etc");
                        continue;
                    }
                    return phoneNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine("not an integer");
                }
            }
        }
        static int getUInt()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter amount of points");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("not a positive integer");
                        continue;
                    }
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("not an integer");
                }
            }
        }
    }
}
