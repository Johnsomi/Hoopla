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
        //Section[] sections = new Section[6];
        List<Section> sections = new List<Section>();
        string currentSectionName;

        public Gradebook()
        {
            currentSectionName = "";
        }

        //sets the currently active section - needs to set the currently active section
        //to the section with the given sectionName.
        // Returns: true if it succeeds false if it fails(no section that matches that name).
        public bool changeSection(string sectionName)
        {
            if(sections.Count == 0)
            {
                return false;
            }
            int sectionIndex = getSectionIndexBySectionName(sectionName);
            if (sectionIndex == -1)
            {
                return false;
            }

            currentSectionName = sectionName;
            return true;
        }

        //creates a new section if there are not already 6 sections
        // and sectionName is not already used , also need to set the currentSection to be the new section
        // Returns: true if it succeeds false if it fails.
        public bool addSection(string sectionName)
        {
            //return false if already 6 sections
            if (sections.Count() == 6)
            {
                return false;
            }
            //return false if section name is in use
            int sectionIndex = getSectionIndexBySectionName(sectionName);
            if (sectionIndex != -1)
            {
                return false;
            }
            //otherwise
            //create new section, add it to (List)sectons  
            sections.Add(new Section(sectionName));
            //set currentSection to the new section
            currentSectionName = sectionName;
            //return true
            return true;

        }
        //Creates a new student and adds the student to the currently active section
        //returns: True if it succeeds, false if it fails(a student with the same username already exists or there are no sections) 
        public bool addStudent(string firstName, string lastName, string username, long phoneNumber)
        {
            //if no sections, return false
            if (sections.Count == 0)
            {
                return false;
            }
            //get current active section
            Section curSection = getCurrentSection();
            if(curSection == null)
            {
                return false;
            }
            //add student to the active section
            return curSection.addStudent(firstName, lastName, username, phoneNumber);            
        }

        //returns overall score (total points earned for all assignments/ total points possible) as a percentage for specified student
        //returns -1 if the student was not found or if the student did not have any assignments assigned or there are no sections.
        public double getOverallScore(string username)
        {
            if(sections.Count == 0)
            {
                return -1;
            }
            Section curSection = getCurrentSection();
            if (curSection == null)
            {
                return -1;
            }
            return curSection.getOverallScore(username);
            //FIXME
        }
        //returns overall score as a percentage for the current section - (the average of each students overall score.)
        //Each student should have the same weight even if they have different number of points possible
        //IE: get each student's overall score as a percentage and calculate the average percentage for the students .
        //do not count students with no assignments assigned in the average.
        //returns -1 if there were no assignments in the section or there are no sections.
        public double getOverallScoreAvg()
        {
            return -1; //FIXME
        }


        //creates a new assignment and adds it to the student specified by username.
        //Returns true if it succeeds and false if the student is not found or the student already has an assignment with the
        //same assignmentName or there are no sections
        public bool addAssignmentToStudent(string username, string assignmentName, int pointsPossible)
        {
            if(sections.Count == 0)
            {
                return false;
            }
            Section curSection = getCurrentSection();
            if(curSection == null)
            {
                return false;
            }
            return curSection.addAssignmentToStudent(username, assignmentName, pointsPossible);
            
        }

        //checks to make sure no student already has an assignment with the same assignment name first
        //if there is no existing assignment it creates a new assignment and adds the assignment to all
        // the students in the current section.
        //returns: True if successful and false if at least one student has the same assignment name or there are no sections
        public bool addAssignmentToSection(string assignmentName, int pointsPossible)
        {
            if(sections.Count == 0)
            {
                return false;
            }

            Section curSection = getCurrentSection();
            if (curSection == null)
            {
                return false;
            }
            return curSection.addAssignmentToSection(assignmentName, pointsPossible);
            
        }

        //sets the pointsEarned property for the student specified in the current section for the assignment specified
        //returns: true if successful, false if the student is not found or the assignmentName is not found  or there are no sections.
        public bool setScore(string username, string assignmentName, int pointsEarned)
        {
            if (sections.Count == 0)
            {
                return false;
            }

            Section curSection = getCurrentSection();
            if (curSection == null)
            {
                return false;
            }
            return curSection.setScore(username, assignmentName, pointsEarned);
            
        }

        //returns score on assignment specified as a percentage for the specified student in the current section
        //returns -1 if the student was not found or the student did not have an assignment with the specified assignment name or there are no sections
        public double getAssignmentScorePercent(string username, string assignmentName)
        {
            return -1;//FIXME
        }

        //returns the average score as a percentage for the current section.
        //only the student with the assignment assigned to them will be counted in the average.
        //returns -1 if no student had an assignment with the specified assignment name  or there are no sections
        public double getAssignmentScoreAvg(string assignmentName)
        {
            return -1;//FIXME
        }

        //adds 1 to the specified student's tardy count.
        //returns: true if successful, false if the student was not found in the current section  or there are no sections
        public bool markTardy(string username)
        {
            //if no sections, return false
            if(sections.Count == 0)
            {
                return false;
            }
            //get current active section
            Section curSection = getCurrentSection();
            if (curSection == null)
            {
                return false;
            }
            //mark student as tardy
            return curSection.markTardy(username);
        }

        //adds 1 to the specified student's absent count.
        //returns: true if successful, false if the student was not found in the current section  or there are no sections
        public bool markAbsent(string username)
        {
            if (sections.Count == 0)
            {
                return false;
            }
            //get current active section
            Section curSection = getCurrentSection();
            if (curSection == null)
            {
                return false;
            }
            //mark student as absent
            return curSection.markAbsent(username);
        }

        //returns the student tardy count for the specified student, it returns -1 if the student was not found  or there are no sections
        public int getTardyCount(string username)
        {
            return -1; //FIXME
        }

        //returns the student tardy count for the specified student, it returns -1 if the student was not found  or there are no sections
        public int getAbsentCount(string username)
        {
            return -1; //FIXME
        }

        //returns -1 if no section was found with the given section name
        //otherwise returns the index of the section with the matching name
        private int getSectionIndexBySectionName(string sectionName)
        {
            int index = 0;  // |   |   |   |   |
            while (index < sections.Count())
            {
                if (sectionName.Equals(sections[index].getSectionName()))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        //return the section if there are any sections
        //return null if there is no current section
        private Section getCurrentSection()
        {
            //getSectionIndex(currentSectionName)
            int index = getSectionIndexBySectionName(currentSectionName);
            //if index = -1, return null
            if (index == -1)
            {
                return null;
            }
            //otherwise return section at that index
            return sections[index];
        }
    }
}
