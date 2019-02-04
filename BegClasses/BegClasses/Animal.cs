using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    public class Animal
    {
        string species;
        string name;
        string color;
        int age;

        public Animal()
        {
            color = "Black";
            name = "Billy";
            species = "Bear";
            age = 0;
        }
        
        public Animal(string Species, string Name, string Color)
        {
            color = Color;
            name = Name;
            species = Species;
            
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrrr");
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public void PrintDescription()
        {
            Console.WriteLine(name + " is a " + age + " year old, " + color + " " + species);
        }
    }
}
