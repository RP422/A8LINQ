using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    public static class Extensions
    {
        //Q01
        public static void PrintResults(this IEnumerable<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }
        }

        //Q10
        public static void PrintResults(this IOrderedEnumerable<IGrouping<char, Student>> students)
        {
            foreach (var groupOfStudents in students)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(student);
                }
            }
        }

        //Q12
        public static void PrintAverageTestScoreByStudent(this IEnumerable<Student> students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine(student + "; Average: " + student.Scores.Average());
            }
        }

        //Q13
        public static void AverageScoresByTest(this IEnumerable<Student> students)
        {
            double average;
            int count = students.ToArray().Length;

            for (int x = 0; x < students.First().Scores.ToArray().Length; x++)
            {
                average = 0;
                foreach(Student student in students)
                {
                    average += student.Scores.ElementAt(x);
                }
                average /= count;

                Console.WriteLine("Average for test " + (x + 1) + ": " + average);
            }
        }
    }
}
