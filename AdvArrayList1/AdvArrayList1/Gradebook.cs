using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    public class Gradebook
    {
        //properties
        //list/array of sections
        Section[] sections = new Section[6];
        int currentSection;

        //Methods(external API - methods that will be exposed to user to allow the user to interact with your gradebook):  
        //functions that return boolean values: (true means successful, false means it could not add/set etc)

        //changeSection(string sectionName); sets the currently active section

        //*//boolean AddStudent(String firstName, String lastName, string username, long phoneNumber); //creates a new student

        //double getOverallScore(String username) //returns overall score as a percentage for specified student

        //double getOverallScoreAvg(String sectionName) //returns overall score as a percentage for a section

        //boolean addAssignmentToStudent(String username, String assignmentName, int pointsPossible)

        //boolean addAssignmentToSection(String assignmentName, int pointsPossible)

        //boolean setScore(String username, String assignmentName, int pointsEarned)

        //double getAssignmentScorePercent(String username, String assignmentName) //returns score as a percentage for student in current section

        //double getAssignmentScoreAvg(String assignmentName) //returns score as a percentage for current section

        //// //boolean addSection(String sectionName)//creates a new section if there are not already 6 sections and sectionName isnt already used 

        //boolean markTardy(String username) //adds 1 to the students tardy count

        //boolean markAbsent(String username) //adds 1 to the students absent count

        //int getTardyCount(String username)  //returns number of times student was tardy

        //int getAbsentCount(String username) //returns number of times student was absent
    }
}
