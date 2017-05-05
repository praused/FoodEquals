using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string banana = "banana";
            string banana2 = string.Copy(banana);
            
            //ReferenceEquals() is a Static Method, so it cannot be overwritten.

            Console.WriteLine(banana);
            Console.WriteLine(banana2);
            Console.WriteLine(ReferenceEquals(banana, banana2));//returns false
            Console.WriteLine(banana.Equals((object)banana2));//returns true
        }
    }
}
