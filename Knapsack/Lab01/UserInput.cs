using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class UserInput
    {
        public string input;
        public int seed;
        public int itemCount;
        public int knapsackSize;
        public void GetUserInput()
        {
            Console.WriteLine("Enter the seed: ");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input provided.");
                Random r = new Random();
                seed = r.Next(0, Int32.MaxValue);
                Console.WriteLine($"Seed randomly generated is: {seed}");
            }
            else
            {
                if (int.TryParse(input, out seed))
                {
                    Console.WriteLine("Seed entered: " + seed);
                }
                else
                {
                    Console.WriteLine("Invalid seed. Enter a valid integer!");
                }
            }
            Console.WriteLine("Enter knapsack size: ");
            knapsackSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter item count: ");
            itemCount = int.Parse(Console.ReadLine());
        }
    }
}
