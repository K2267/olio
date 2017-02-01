using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one student einstance
            Opiskelijat Seppo = new Opiskelijat();
            Seppo.Name = "Seppo Kulovi";
            Seppo.StudentId = "K1234";
            Seppo.Age = 40;
            Seppo.Group = "TTVK1";

            // display student data
            Seppo.PrintData();
            Console.ReadLine();
            Seppo.Ageing();
            Seppo.OtherInfo(); //Happy Birthday

            Seppo.PrintData();
            Console.ReadLine();

            //2nd student
            
            Opiskelijat Ismo = new Opiskelijat();
            Ismo.Name = "Ismo Kortone";
            Ismo.StudentId = "K0987";
            Ismo.Age = 57;
            Ismo.Group = "TTVK1";

            // display student data
            Ismo.PrintData();
            Console.ReadLine();
            // Ismo want to change group
            Ismo.GroupChange();
            // display car data again, notice changed group!
            Ismo.PrintData();
            Console.ReadLine();


        }
    }
}