using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleTypesChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge Objectives
            // - Create a SortedList<> object
            // - The SortedList should store string values
            // - Add three values to the SortedList
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "charlie");
            sortedList.Add(2, "bravo");
            sortedList.Add(1, "alpha");

            // Display sortedList Contents
            PrintSortedListValues(sortedList);


            // Instructor's Solution
            SortedList<string, string> mySortedList = new SortedList<string, string>();
            mySortedList.Add("first", "Gerry");
            mySortedList.Add("last", "O'Brien");
        }

        // Print SortedList Key, Value Pairs
        public static void PrintSortedListValues( SortedList<int, string> list)
        {
            for(int i = 1; i <= list.Count; i++)
            {
                string value;
                list.TryGetValue(i, out value);
                Console.WriteLine("Value: " + value);
            }
        }
    }
}
