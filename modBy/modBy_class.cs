using System;
using System.Collections;

namespace modBy
{
    // To hold our value pairs
    struct divisbleBy
    {
        public int modBy;
        public string returnValue;
    };

    public class modBy_class
    {
        int upperBounds;
        divisbleBy[] structs;

        // Asks the user for all the required values: upperBounds, Size of pairs, modby, and returnValue
        public void getValues()
        {
            int size;
            bool numCheck; // this is to verify a number was entered. If not the program will ask for a proper value

            // Loop through both the upper bounds and the number of pairs in order to verify correct input.
            do {
                Console.WriteLine("What is the upper bounds?");
                numCheck = int.TryParse(Console.ReadLine(), out upperBounds);
            } while (!numCheck);

            do {
                Console.WriteLine("How many pairs of %'s and return statements are there?");
                numCheck = int.TryParse(Console.ReadLine(), out size);
            } while (!numCheck);
            
            // create a new array of structs 
            structs = new divisbleBy[size];

            // for each value in our array of struct, we verify we can get an int and then a string for the output
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter an integer % value for {0} out of {1}", i + 1, size);
                numCheck = int.TryParse(Console.ReadLine(), out structs[i].modBy);

                //in case of invalid number, move the counter back one and continue through
                if (!numCheck)
                {
                    i--;
                    continue;
                }

                Console.WriteLine("What is the return value for mod by {0}", structs[i].modBy);
                structs[i].returnValue = Console.ReadLine();
            }
            
        }

        /* Loops 1 through upperBounds and 0 through the number of pairs (size) finding if each number is mod-able by the given number
         * After checking through, we loop through any remaining values (null) and assign them their proper number.
         * 
         * Note: Using int.MaxValue will break the program due to Memory Limitions as there is a 2GB limit
         */
        public string[] checkMod()
        {
            string[] output = new string[upperBounds];

            // for each value(s) found in our struct we want to check the different mod bys
            for(int i = 0; i < structs.Length; i++)
            {
                // for each value between 1 and upperBounds
                for(int j = 1; j <= upperBounds; j++)
                {
                    // check if j is evenly divisible by struct[i].modBy
                    if(j % structs[i].modBy == 0)
                    {
                        // add to our input as some values could be divisible by more than one number
                        output[j - 1] += structs[i].returnValue + " ";
                    }
                }
            }

            // this is a final pass through the list to add any remaining values
            for(int k = 1; k <= upperBounds; k++)
            {
                if (output[k - 1] == null)
                {
                    output[k - 1] += k + "";
                }
            }

            return output;
        }
    }
}
