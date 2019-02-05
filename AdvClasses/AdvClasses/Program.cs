using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Bill", "cat");
            animal.MakeSound();
            animal.PrintName();

            Dog dog = new Dog("Jack", true);
            dog.MakeSound();
            dog.PrintName();
            dog.PlayFetch();
            dog.getDockedTail();
            Console.WriteLine(dog.getDockedTail());

            Cat cat = new Cat("Cartman");
            cat.MakeSound();
            cat.PrintName();
            cat.BeHappy();
            cat.SeeLaser();

            OrangeTabby OT = new OrangeTabby("Swig");
            OT.MakeSound();
            OT.PrintName();
            OT.BeHappy();
            OT.LayOnLap();
            OT.SeeLaser();

            RussianBlue RB = new RussianBlue("Timmy");
            RB.MakeSound();
            RB.PrintName();
            RB.BeHappy();
            RB.SeeLaser();

            Garfield garfield = new Garfield();
            garfield.MakeSound();
            garfield.PrintName();
            garfield.BeHappy();
            garfield.LayOnLap();
            garfield.SeeLaser();
            Console.ReadKey();
        }
    }
}
