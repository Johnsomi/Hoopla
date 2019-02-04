using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student IStudent = new Student("Jonny", 12, 17);
            IStudent.SetContentGrade(82);
            IStudent.SetWorkHabitGrade(60);
            IStudent.SetParticipation(50);
            IStudent.GetGrade();
            IStudent.printGrade();
            Console.ReadKey();

        }
    }
}
