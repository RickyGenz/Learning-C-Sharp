using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageElementsChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge Objectives
            // - Create a for loop in C#
            // - Have the loop count to 10
            // - Output each value as the loop counts
            for(int count = 0; count < 11; count++)
            {
                Console.WriteLine(count);
            }

            // Instructor's Solution
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
