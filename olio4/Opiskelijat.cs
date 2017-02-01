using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio4
{
    class Opiskelijat
    {
        // properties

        public string Name { get; set; }
        public string StudentId { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public string Other { get; set; }


        // don't create any constructor, so default one will be used
        public void GroupChange()
        {
            Group = "TTVK20";
        }
        public void Ageing()
        {
            Age = 41;
        }
        public void OtherInfo()
        {
            Other = " Happy Birthday! ";
        }
        


        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Student data : ");
            Console.WriteLine("- Student's name : " + Name);
            Console.WriteLine("- Student ID : " + StudentId);
            Console.WriteLine("- Age : " + Age);
            Console.WriteLine("- Students group : " + Group);
            Console.WriteLine(Other);

        }


        // destructor
        ~Opiskelijat()
        {
            Console.WriteLine("Student object destroyed.");
        }

    }

}