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

        public bool setScore(string username, string assignmentName, int pointsEarned)
        {
            if (students.Count == 0)
            {
                return false;
            }
            Student student = getCurrentStudent(username);
            if (student == null)
            {
                return false;
            }
            if(student.getAssignment(assignmentName) == null)
            {
                return false;
            }
            student.getAssignment(assignmentName).setScore(pointsEarned);
            return true;
        }

        public bool addAssignmentToStudent(string username, string assignmentName, int pointsPossible)
        {
            if (students.Count == 0)
            {
                return false;
            }

            Student student = getCurrentStudent(username);
            if(student == null)
            {
                return false;
            }
            if(student.getAssignment(assignmentName) != null)
            {
                return false;
            }
            student.addAssignment(assignmentName, pointsPossible);
            return true;
        }

        public bool addAssignmentToSection(string assignmentName, int pointsPossible)
        {
            //false if no students
            if(students.Count == 0)
            {
                return false;
            }
            
            int index = 0;
            while(index < students.Count)
            {
                //false if a student has the assignment
                if (students[index].getAssignment(assignmentName) != null)
                {
                    return false;
                }
                index++;
            }
            //loop through students
            index = 0;
            while(index < students.Count)
            {
                students[index].addAssignment(assignmentName, pointsPossible);
                index++;
            }
            return true;
                //addAssignment to the student
        }

        public double getOverallScore(string username)
        {
            if (students.Count == 0)
            {
                return -1;
            }
            Student student = getCurrentStudent(username);
            if (student == null)
            {
                return -1;
            }
            student.getOverallScore();
        }

        //mark the student specified by username tardy (increase tardy count)
        //if student no found return false, otherwise true
        public bool markTardy(string username)
        {
            //get the student specified by username
            Student curStudent = getCurrentStudent(username);
            //if no student return false
            if(curStudent == null)
            {
                return false;
            }
            //mark student as tardy
            curStudent.markTardy();
            return true;
        }

        public bool markAbsent(string username)
        {
            Student curStudent = getCurrentStudent(username);

            if(curStudent == null)
            {
                return false;
            }

            curStudent.markAbsent();
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

        
        
        private Student getCurrentStudent(string username)
        {
            
            int index = getStudentIndexByUsername(username);
            
            if (index == -1)
            {
                return null;
            }
            
            return students[index];
        }
    }
}
