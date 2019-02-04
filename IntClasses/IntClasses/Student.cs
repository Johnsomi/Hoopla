using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses
{
    public class Student
    {
        int studentID;
        string name;
        double contentGrade;
        double workHabitGrade;
        double participation;
        int age;

        public Student(string name, int studentID, int age)
        {
            this.name = name;
            this.studentID = studentID;
            this.age = age;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
        }

        public Student()
        {
            name = "TestStudent";
            studentID = -1;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;
        }

        public void SetContentGrade (int grade)
        {
            contentGrade = grade;
        }

        public void SetWorkHabitGrade(int grade)
        {
            workHabitGrade = grade;
        }

        public void SetParticipation(int grade)
        {
            participation = grade;
        }

        public double GetGrade()
        {
            double grade = 0.35 * workHabitGrade + 0.4 * contentGrade + 0.25 * participation;
            return grade;
        }

        public void printGrade()
        {
            Console.WriteLine(GetGrade());
        }
    }
}
