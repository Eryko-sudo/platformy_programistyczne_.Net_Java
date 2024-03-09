using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Result
    {

        public int totalValue;
        public int totalWeight;

        List<Item> ListOfResults = new List<Item>();

        public Result(List<Item> List) {

            ListOfResults = List;
        }

        public void PrintKnapsackContents() // ToString
        {
            ListOfResults.Sort((x, y) => (y.value * 1.0 / y.weight).CompareTo(x.value * 1.0 / x.weight));

            Console.WriteLine("List of items inside the knapsack:");
            foreach (var item in ListOfResults)
            {
                Console.WriteLine($"Nr. {item.index}        Value: {item.value}      Weight: {item.weight}");
                totalValue += item.value;
                totalWeight += item.weight;
            }
            Console.WriteLine($"Knapsack value: {totalValue}");
            Console.WriteLine($"Knapsack weight: {totalWeight}");

        }
    }
}
