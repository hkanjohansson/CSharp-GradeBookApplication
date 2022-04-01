using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
            IsWeighted = isWeighted;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            Console.WriteLine(averageGrade);
            char grade = 'F';
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of five students to work");
            }

            if (averageGrade > 75)
            {
                grade = 'A';
            }
            else if (averageGrade > 50)
            {
                grade = 'B';
            }
            else if (averageGrade > 25)
            {
                grade = 'C';
            }
            else if (averageGrade > 0)
            {
                grade = 'D';
            }
                
            
            return grade;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }
    }
}
