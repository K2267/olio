using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car einstance
            Televisio Televisio = new Televisio();
            Televisio.OnOff = false;
            Televisio.Model = "LG";
            Televisio.Inches = 55;
            Televisio.Color = "Steel";
            Televisio.Program = "none";
            Televisio.Uhd = true;
            Televisio.Hdr = true;

            // display car data
            Televisio.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            Televisio.Start();
            Televisio.Channelchange();
            Televisio.Whatprogram();
            // display car data again, notice changed speed value!
            Televisio.PrintData();
            Console.ReadLine();
        }
    }
}
