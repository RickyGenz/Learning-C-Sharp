using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageElementsChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge Objectives
            // - Create a function in C#
            // - This function will not return a value
            // - It should accept two integers
            // - It should add the integers to form a sum
            // - Output the sum to the console window
            DisplaySum(11, 99); // 110

            // Instructor's Solution
            Sum(32, 45); // 77
        }

        // Custom Function to meet Challenege Objectives
        static void DisplaySum(int one, int two)
        {
            Console.WriteLine(one + two);
        }

        // Instructor's Solution
        static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
