using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge Objectives
            // - Instantiate a Car object
            // - Set values for the data
            // - Call the two methods
            Car Hybrid = new Car();

            // Configure Hybrid
            Hybrid.Make = "Toyota";
            Hybrid.Model = "Prius";
            Hybrid.Color = "Black";

            // Check Hybrid Properties
            Console.WriteLine("Make: " + Hybrid.Make);
            Console.WriteLine("Model: " + Hybrid.Model);
            Console.WriteLine("Color: " + Hybrid.Color);

            // Use Hybrid
            Hybrid.Drive();
            Hybrid.Stop();


            // Instructor's Solution
            CarIS myCar = new CarIS();

            myCar.make = "Chevrolet";
            myCar.model = "Camaro";
            myCar.color = "Black";

            myCar.Drive();
            myCar.Stop();
        }
    }
}
