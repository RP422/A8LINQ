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

        public static int SortAlphabetical(this Student s, Student other)
        {
            int result = s.Last.CompareTo(other.Last);
            if(result == 0)
            {
                result = s.First.CompareTo(other.First);
                if(result == 0)
                {
                    result = s.ID.CompareTo(other.ID);
                }
            }
            return result;
        }
    }
}
