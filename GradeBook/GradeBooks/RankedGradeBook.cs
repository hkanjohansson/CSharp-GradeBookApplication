using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char grade = 'F';
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of five students to work");
            }

            if (averageGrade >= 0.9)
            {
                grade = 'A';
            }
            else if (averageGrade >= 0.8)
            {
                grade = 'B';
            }
            else if (averageGrade >= 0.7)
            {
                grade = 'C';
            }
            else if (averageGrade >= 0.6)
            {
                grade = 'D';
            }
                
            
            return grade;
        }
    }
}
