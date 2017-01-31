using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Pesukone Pesukone = new Pesukone();
            Pesukone.OnOff = false;
            Pesukone.Model = "Bosch";
            Pesukone.Hiiliharjaton = true;
            Pesukone.Kilos = 7.0;
            Pesukone.Linkous = 0;

            // display car data
            Pesukone.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            Pesukone.Start();
            Pesukone.Accelerate();
            // display car data again, notice changed speed value!
            Pesukone.PrintData();
            Console.ReadLine();
        }
    }
}