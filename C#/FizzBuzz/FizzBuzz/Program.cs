using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0, buzz = 0, fizzBuzz = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 15) == 0) { Console.WriteLine("FizzBuzz"); fizzBuzz++; }
                else if ((i % 3) == 0) { Console.WriteLine("Fizz"); fizz++; }
                else if ((i % 5) == 0) { Console.WriteLine("Buzz"); buzz++; }
                else Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
