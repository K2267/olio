using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car einstance
            Vehicle Vehicle = new Vehicle();
            Vehicle.Name = "Ford";
            Vehicle.Speed = 100;
            Vehicle.Tyres = 4;


            // display car data
            Vehicle.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            Vehicle.Accelerate();

            // display car data again, notice changed speed value!
            Vehicle.PrintData();
            Console.ReadLine();
            Console.WriteLine(Vehicle.ToString());

        }
    }
}