using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class

            Heater Kiuas = new Heater();

            // set values
            Kiuas.IsOn = true;
            Kiuas.Temperature = 80;
            Kiuas.Humidity = 75;

            // Prints data
            Kiuas.PrintDetails();
            Kiuas.Heating();
            // Prints changed data -- > temperaature increased
            Console.ReadLine();
            Kiuas.PrintDetails();
        }
    }
}
