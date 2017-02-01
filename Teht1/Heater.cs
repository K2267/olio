using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Heater
    {
        // properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }
       
 

        // methods
        public void PrintDetails()
        {
            Console.WriteLine("Harvia");
            Console.WriteLine("- Power : " + IsOn);
            Console.WriteLine("- Temperature : " + Temperature);
            Console.WriteLine("- Humidity :  " + Humidity);
        }

        public void Power(bool set)
        {
            IsOn = true;
        }
        public void Heating()
        {
            Temperature += 20;
        }


    }
}