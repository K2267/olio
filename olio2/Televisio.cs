using System;

namespace CarApplication
{
    class Televisio
    {
        // properties
        public bool OnOff { get; set; }
        public string Model { get; set; }
        public int Inches { get; set; }
        public string Color { get; set; }
        public bool Uhd { get; set; }
        public bool Hdr { get; set; }
        public string Channel { get; set; }
        public string Program { get; set; }


        // don't create any constructor, so default one will be used
        public void Start()
        {
            OnOff = true;
        }

        // method to change channel
        public void Channelchange()
        {
            Channel = " 22- Yle TV2HD";
        }

        public void Whatprogram()
        {
            Program = " UEFA Champions League BAY - BAR";
        }

        // method to solve is it UHD?
        public void IsUhd()
        {
            Uhd = true;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Washing machine data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- TV's color : " + Color);
            Console.WriteLine("- Is it UHD TV : "+ Uhd);
            Console.WriteLine("- Is it HDR TV : " + Hdr);
            Console.WriteLine("- Channel is : " + Channel);
            Console.WriteLine("- Channels program : " + Program);
            Console.WriteLine("- Is it on? " + OnOff);

        }

        // destructor
        ~Televisio()
        {
            Console.WriteLine("Tv object destroyed.");
        }

    }

}