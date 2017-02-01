using System;

namespace Coffee
{
    class Coffeemaker
    {
        // properties

        public string Model { get; set; }
        public double Capacity { get; set; }
        public string Color { get; set; }
        public bool OnOff { get; set; }


        // don't create any constructor, so default one will be used
        public void OnorOff()
        {
            OnOff = true;
        }
        public void HowManyCups()
        {
            Capacity = 0.75;
        }




        // method to display data
        public void PrintData()
        {
            Console.WriteLine("Coffeemaker data : ");
            Console.WriteLine("- Model : " + Model);
            Console.WriteLine("- How much coffee : " + Capacity + "liters");
            Console.WriteLine("- Machines color : " + Color);
            Console.WriteLine("- Is it on ? " + OnOff );

        }

        // destructor
        ~Coffeemaker()
        {
            Console.WriteLine("Object destroyed. ");
        }

    }

}