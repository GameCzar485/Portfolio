using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/   |");
            //string firstName = "Matthew";
            //Console.WriteLine(firstName.Length);
            //Console.WriteLine(firstName.ToUpper());
            //Console.WriteLine(firstName.Contains("w"));
            //Console.WriteLine(firstName[2]);
            //Console.WriteLine(2 * (4 + 5));
            //int myAge = 21;
            //myAge++;
            //Console.WriteLine(myAge);
            //myAge--;
            //Console.WriteLine(myAge);

            Console.WriteLine("Fahrenheit to Celsius(input C)or Celsius to Fahrenheit(input F)?");
            string fC = Console.ReadLine();
            Console.WriteLine("What Temperature?");
            string temp = Console.ReadLine();
            if (fC == "C" || fC == "c")
            {
                float convert = (float.Parse(temp) - 32.0f) * (5.0f / 9.0f);
                Console.WriteLine(convert);
            }
            else if (fC == "F" || fC == "f")
            {
                float convert = (float.Parse(temp) / (5.0f / 9.0f)) + 32.0f;
                Console.WriteLine(convert);
            }
            else
            {
                Console.WriteLine("invalid input, please run program again.");
            }

            


        }
    }
}
