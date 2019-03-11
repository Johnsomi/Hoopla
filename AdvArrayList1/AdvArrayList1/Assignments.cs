using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArrayList1
{
    class Assignments
    {
        
        //assignments score
        string assignmentName;

        int pointsEarned;
        int pointsPossible;

        Assignments(string AssignmentName,int PointsEarned, int PointsPossible)
        {
            assignmentName = AssignmentName;
            pointsEarned = PointsEarned;
            pointsPossible = PointsPossible;
        }
    }
}
