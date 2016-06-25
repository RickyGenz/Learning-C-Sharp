using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedChallengeOne
{
    // Challenge Objectives
    // - Create a class called Car
    // - Store make, model, and color in class
    // - Create a Drive method to print "Driving"
    // - Create a Stop method to print "Stopping"
    class Car
    {
        // Encapsulation of Properties
            // Private Properties
            private string make;
            private string model;
            private string color;

            // Public Properties for Getting
            // and Setting Private Properties
            public string Make
            {
                get { return this.make; }
                set { this.make = value; }
            }
            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }
            public string Color
            {
                get { return this.color; }
                set { this.color = value; }
            }

        // Polymorphism Methods
            // Drive Method
            // - Prints "Driving" to Console
            public virtual void Drive()
            {
                Console.WriteLine("Driving");
            }

            // Stop Method
            // - Prints "Stopping" to Console
            public virtual void Stop()
            {
                Console.WriteLine("Stopping");
            }
    }

    // Instructor's Solution
    class CarIS // Car
    {
        public string make;
        public string model;
        public string color;

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}
