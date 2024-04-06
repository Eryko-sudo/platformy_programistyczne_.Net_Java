using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab00
{
    internal class FizzBuzz
    {
        public int number = 0;
        public int up;
        public FizzBuzz(int number)
        {
            this.up = number;
        }

        public void Display()
        {
            Console.WriteLine("Result: ");
            while (number < up)
            {
                number++;


                if (DivisibleByFive() && DivisibleByThree())
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (DivisibleByThree())
                {
                    Console.WriteLine("Fizz");
                }
                else if (DivisibleByFive())
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }

        public bool DivisibleByThree()
        {
            if (number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DivisibleByFive()
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
