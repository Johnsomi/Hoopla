using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    public class Assignment
    {
        
        //assignments score
        string assignmentName;

        int pointsEarned;
        int pointsPossible;

        public Assignment(int pointsPossible, int pointsEarned, string assignmentName)
        {
            this.assignmentName = assignmentName;
            this.pointsEarned = pointsEarned;
            this.pointsPossible = pointsPossible;
        }

        public string getAssignmentName()
        {
            return assignmentName;
        }

        public void setScore(int score)
        {
            pointsEarned = score;
        }

        public int getPointsEarned()
        {
            return pointsEarned;
        }

        public int getPointsPossible()
        {
            return pointsPossible;
        }
    }
}
