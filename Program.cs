using System;
using System.Collections.Generic;

// Instructions

// Using the Random class, generate a list of 20 random numbers that are in the range of 1-50. 
// With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.
// Then remove any number that is odd from the list of squared numbers.

namespace random_square
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate random number generator using system-supplied value as seed.
            Random randomNum = new Random();
                // Create a list
                var firstList = new List<int>();
                // Populate the list
                // Generating a list of 20 numbers
                for (var i = 0; i < 20; i++) {
                    // The Next Method returns a non-negative random integer
                    // Establishing that the range is between 1 and 50
                    int num = randomNum.Next(1, 51);
                    // Getting each sqaured number and adding it to the firstList List
                    firstList.Add(num * num);
                }
                // "RemoveAll();" Removes all the elements that match the conditions defined by the specified predicate.
                // Calculates the remainder of i divided by 2. If i is an even number, the result will be 0 and if it is an odd number, the result will be 1. So this if statement checks to see if i is an even number.
                // If it equals 1 it's an odd number 
                firstList.RemoveAll(i => i % 2 != 0);
                
                foreach (var remainingnum in firstList) 
                {
                    Console.WriteLine(remainingnum);
                }

        }
    }
}
