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
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            //equality with the Static Equals() Method.
            //same results as the Virtual Method, except with nulls.

            //Console.WriteLine(banana.Equals(null));
            Console.WriteLine(object.Equals(banana2, null));
            Console.WriteLine(object.Equals(null, banana2));
            Console.WriteLine(object.Equals(null, null)); //returns true
        }
    }
}
