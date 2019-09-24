using System;

namespace edXObjectOrientedProgramming
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Car1 = new Car();

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
        }
    }
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
