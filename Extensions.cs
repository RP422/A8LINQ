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
        public static void PrintResults(this IEnumerable<Student> list)
        {
            foreach (Student s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
