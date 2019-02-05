using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class RussianBlue
    {
        string species;
        string name;

        public RussianBlue(string name)
        {
            species = "cat";
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Hisss");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrr");
            SeeLaser();
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
