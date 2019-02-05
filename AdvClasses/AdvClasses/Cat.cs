using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class Cat
    {
        string species;
        string name;

        public Cat(string name)
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
            Console.WriteLine("purrrr");
            SeeLaser();
            MakeSound();
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces");
        }
    }
}
