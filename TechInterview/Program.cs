using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modBy;

namespace TechInterview
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            // Intialize the class
            modBy_class modBy = new modBy_class();

            // Setup the values, this includes asking for the upper bounds, # of pairs, mod values, and return values
            modBy.getValues();

            // check 1 - upper bounds for the given mod values and either print the return value(s) or just the integer
            string[] values = modBy.checkMod();

            // Iterate through our list
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.ReadKey();
        }
    }
}
