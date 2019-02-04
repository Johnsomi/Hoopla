using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal AAnimal = new Animal("cat", "will", "blue");

            
            AAnimal.MakeSound();
            AAnimal.SetAge(5);
            AAnimal.PrintDescription();
            Console.ReadKey();
        }
    }
}
