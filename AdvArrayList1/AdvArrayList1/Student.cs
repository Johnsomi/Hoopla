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
    }
}
