using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class Animal
    {
        string species;
        string name;

        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrrr");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
