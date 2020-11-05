using GradeBook.GradeBooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {



        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new System.InvalidOperationException("Count of students is less than 5");
            }
            else if (averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60 && averageGrade < 80)
            {
                return 'B';
            }
            else if (averageGrade >= 40 && averageGrade < 60)
            {
                return 'B';
            }
            else if (averageGrade >= 20 && averageGrade < 40)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (Students.Count > 5)
            {
                base.CalculateStatistics(); 
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (Students.Count > 5)
            {
                foreach (var student in Students)
                { 
                    base.CalculateStudentStatistics(student.Name);
                }
            }
        }

    }

}
