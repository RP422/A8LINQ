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
            var firstQuery = Student.students.Where(FilterGarcia);
            firstQuery.PrintResults();

            //Q03
            var secondQuery = from student in Student.students
                              where student.Last == "Garcia"
                              select student;
            secondQuery.PrintResults();
        }

        //Q02
        private static bool FilterGarcia(Student s)
        {
            return s.Last == "Garcia";
        }
    }
}
