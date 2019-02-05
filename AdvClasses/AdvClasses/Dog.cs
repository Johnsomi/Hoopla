using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvClasses
{
    class Dog
    {
        string species;
        string name;
        bool dockedTail;

        public Dog(string name, bool dockedTail)
        {
            species = "Dog";
            this.name = name;
            this.dockedTail = dockedTail;
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void PlayFetch()
        {
            Console.WriteLine("*chases ball 5 times then quits*");
        }

        public bool getDockedTail()
        {
            return dockedTail;
        }
    }
}
