using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car einstance
            Coffeemaker maker = new Coffeemaker();
            maker.Model = "Wilfa";
            maker.Capacity = 0;
            maker.Color = "Brushed Steel ";
            maker.OnOff = false;



            // display data
            maker.PrintData();
            Console.ReadLine();
            // Turn it on
            maker.OnorOff();
            maker.HowManyCups();

            // display data again
            maker.PrintData();
            Console.ReadLine();
            Console.WriteLine(maker.ToString());

        }
    }
}