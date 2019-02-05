using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class OrangeTabby
    {
        string species;
        string name;

        public OrangeTabby(string name)
        {
            species = "cat";
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");           
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            LayOnLap();
            Console.WriteLine("*takes a nap*");
        }

        public void LayOnLap()
        {
            Console.WriteLine("*cuddles on owner's lap*");
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
