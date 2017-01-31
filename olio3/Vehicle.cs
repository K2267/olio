using System;

namespace CarApplication
{
    class Vehicle
    {
        // properties
        
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }


        // don't create any constructor, so default one will be used
        public void Accelerate()
        {
            Speed += 120;
        }

        // 


        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Vehicle data : ");
            Console.WriteLine("- Vehicle model : " + Name);
            Console.WriteLine("- Vehicle's speed : " + Speed);
            Console.WriteLine("- Tyre size : " + Tyres);

        }

        public override string ToString()
        {
            return "Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }

        // destructor
        ~Vehicle()
        {
            Console.WriteLine("Vehicle object destroyed.");
        }

    }

}