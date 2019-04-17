using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    public class Student
    {
        //name
        string firstName;
        string lastName;

        //username
        private string username;

        public string getUsername()
        {
            return username;
        }

        //phone #
        long phoneNumber;

        //tardies
        int daysTardy;

        //absents
        int daysAbsent;

        //list/array of assignments
        List<Assignment> assignments = new List<Assignment>();
        
        public Student (string firstName, string lastName, string username, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.phoneNumber = phoneNumber;
            this.daysAbsent = 0;
            this.daysTardy = 0;
        }

        public void markTardy()
        {
            daysTardy++;
        }

        public void markAbsent()
        {
            daysAbsent++;
        }

        //returns -1 if no student was found with the given username name
        //otherwise returns the index of the student with the matching username
        public int getAssignmentIndexByAssignmentName(string assignmentName)
        {
            int index = 0;  // |   |   |   |   |
            while (index < assignments.Count())
            {
                if (assignmentName.Equals(assignments[index].getAssignmentName()))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public double getOverallScore()
        {
            double totalPointsEarned = 0;
            double totalPointsPossible = 0;
            //if student has no assignment return -1
            if(assignments.Count == 0)
            {
                return -1;
            }
            int index = 0;
            while (index < assignments.Count())
            {
                //get points earned for first assignment
                totalPointsEarned += assignments[index].getPointsEarned();
                //then add new points earned to old one
                totalPointsPossible += assignments[index].getPointsPossible();
                index++;
            }
            //loop through all assignments
            //add points earned / points possible
            return Math.Round((totalPointsEarned / totalPointsPossible) * 100, 1);
        }

        public Assignment getAssignment(string assignmentName)
        {

            int index = getAssignmentIndexByAssignmentName(assignmentName);

            if (index == -1)
            {
                return null;
            }

            return assignments[index];
        }

        public void addAssignment(string assignmentName, int pointsPossible)
        {
            assignments.Add(new Assignment(pointsPossible, 0, assignmentName));
        }
    }
}
