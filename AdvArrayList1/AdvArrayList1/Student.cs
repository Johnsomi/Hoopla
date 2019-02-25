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
        string username;

        //phone #
        long phoneNumber;

        //tardies
        int tardies;

        //absents
        int absents;

        //list/array of assignments
        List<Assignments> assignments = new List<Assignments>();
        
    }
}
