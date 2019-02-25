using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[50];
            int[] arrayOfNumbers = new int[3];
            int[] numbersArray = new int[5];

            double[] dblArray = new double[4];
            double[] arrayOfDoubles = new double[15];
            double[] playerPoints = new double[39];

            string[] stringArray1 = new string[20];
            string[] arrayOfStrings = new string[25];
            string[] wordArray = new string[6];

            numbersArray[0] = 12;
            numbersArray[1] = 13;
            numbersArray[2] = 14;
            numbersArray[3] = 15;
            numbersArray[4] = 16;

            arrayOfNumbers[0] = 47;
            arrayOfNumbers[1] = 46;
            arrayOfNumbers[2] = 39;

            dblArray[0] = 12.43;
            dblArray[1] = 5.12;
            dblArray[2] = 43.21;
            dblArray[3] = 1.34;

            wordArray[0] = "What";
            wordArray[1] = "is";
            wordArray[2] = "Forrest";
            wordArray[3] = "Gump's";
            wordArray[4] = "password?";
            wordArray[5] = "1Forrest1";

            Console.WriteLine(numbersArray[0]);
            Console.WriteLine(numbersArray[1]);
            Console.WriteLine(numbersArray[2]);
            Console.WriteLine(numbersArray[3]);

            Console.WriteLine(wordArray[0]);
            Console.WriteLine(wordArray[1]);
            Console.WriteLine(wordArray[2]);
            Console.WriteLine(wordArray[3]);
            Console.WriteLine(wordArray[4]);
            Console.WriteLine(wordArray[5]);

            Console.ReadKey();

        }
    }
}
