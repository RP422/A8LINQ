using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Q02
            var firstQuery = Student.students.Where(FilterGarcia);
            firstQuery.PrintResults();
            Console.WriteLine();

            //Q03
            var secondQuery = from student in Student.students
                              where student.Last == "Garcia"
                              select student;
            secondQuery.PrintResults();
            Console.WriteLine();

            //Q04
            List<Student> list = new List<Student>(Student.students);
            var thirdQuery = from student in Student.students
                                 orderby student.Last, student.First, student.ID
                                 select student;
            thirdQuery.PrintResults();
            Console.WriteLine();

            //Q06
            Console.WriteLine(thirdQuery.FirstOrDefault());
            Console.WriteLine();

            //Q08
            var fourthQuery = from student in Student.students
                              group student by student.Last[0] into studentGroup
                              orderby studentGroup.Key
                              select studentGroup;
            fourthQuery.PrintResults();
            Console.WriteLine();

            Console.WriteLine("Average test score per student:");
            Student.students.PrintAverageTestScoreByStudent();
            Console.WriteLine();
            Student.students.AverageScoresByTest());
        }

        //Q02
        private static bool FilterGarcia(Student s)
        {
            return s.Last == "Garcia";
        }

        public static int SortAlphabetical(Student s, Student other)
        {
            int result = s.Last.CompareTo(other.Last);
            if (result == 0)
            {
                result = s.First.CompareTo(other.First);
                if (result == 0)
                {
                    result = s.ID.CompareTo(other.ID);
                }
            }
            return result;
        }
    }
}
