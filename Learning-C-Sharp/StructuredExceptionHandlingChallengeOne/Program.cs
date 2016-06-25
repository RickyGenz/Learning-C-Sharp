using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredExceptionHandlingChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge Objectives
            // - Use exisitng code
            //  - int intValue = 32;
            //  - object objValue = intValue;
            //  - string strValue;
            //  - strValue = (string)objValue;
            // - Create exception handling routine
            // - Catch the InvalidCastException
            // - Output the exception message
            try
            {
                int intValue = 32;
                object objValue = intValue;
                string strValue;

                strValue = (string)objValue;
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // Instructor's Solution
            int intValueIS = 32;
            object objValueIS = intValueIS;
            string strValueIS;

            try
            {
                strValueIS = (string)objValueIS;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
