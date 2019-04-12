using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    public class Section
    {
        //List/Array of students
        private List<Student> students = new List<Student>();

        //section name int
        private string sectionName;

        public Section(string sectionName)
        {
            this.sectionName = sectionName;           
        }

        public string getSectionName()
        {
            return sectionName;
        }

        //create new student if the username does not exist and add to the studentList
        //returns false if username exists, returns true otherwise
        public bool addStudent(string firstName, string lastName, string username, long phoneNumber)
        {
            //check if username exists
            int studentIndex = getStudentIndexByUsername(username);
            //if exists return false
            if(studentIndex != -1)
            {
                return false;
            }
            //otherwise create student and add and return true
            students.Add(new Student(firstName, lastName, username, phoneNumber));
            return true;
        }

        //returns -1 if no student was found with the given username name
        //otherwise returns the index of the student with the matching username
        private int getStudentIndexByUsername(string username)
        {
            int index = 0;  // |   |   |   |   |
            while (index < students.Count())
            {
                if (username.Equals(students[index].getUsername()))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
