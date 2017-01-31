using System;

namespace CarApplication
{
    class Pesukone
    {
        // properties
        public bool OnOff { get; set; }
        public string Model { get; set; }
        public bool Hiiliharjaton { get; set; }
        public double Kilos { get; set; }
        public int Linkous { get; set; }


        // don't create any constructor, so default one will be used
        public void Start()
        {
            OnOff = true;
        }

        // method to give more speed
        public void Accelerate()
        {
            Linkous += 1200;
        }

        // method to slow down
        public void Weight()
        {
            Kilos += 5;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Washing machine data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- hiiliharjatonmoottori : " + Hiiliharjaton);
            Console.WriteLine("- Laudry size : " + Kilos);
            Console.WriteLine("- Drum speed : " + Linkous);
            Console.WriteLine("- Is it on? " + OnOff);

        }

        // destructor
        ~Pesukone()
        {
            Console.WriteLine("Car object destroyed.");
        }

    }

}