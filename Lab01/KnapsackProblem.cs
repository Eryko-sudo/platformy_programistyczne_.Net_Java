using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class KnapsackProblem
    {
        public int size;
        public int itemCount;
        public int totalValue;
        public int totalWeight;
        public int seed;


        public KnapsackProblem(int size, int seed) { 
            this.size = size;
            this.seed = seed;
        }

        public List<Item> ListOfItems = new List<Item>();

        public static List<Item> CreateRandomList(int itemCount, int seed)
        {
            List<Item> ListOfItems = new List<Item>();
            Random r = new Random(seed);

            for (int i = 0; i < itemCount; i++)
            {
                int value = r.Next(1, 10);
                int weight = r.Next(1, 10);

                Item newItem = new Item(value, weight, i + 1);
                ListOfItems.Add(newItem);
 
            }

            return ListOfItems;
        }

        public static List<Item> SolveKnapsack(List<Item> items, KnapsackProblem knapsack)
        {
            items.Sort((x, y) => (y.value * 1.0 / y.weight).CompareTo(x.value * 1.0 / x.weight)); // Overload

            foreach (var item in items)
            {
                if (knapsack.size >= item.weight)
                {
                    knapsack.ListOfItems.Add(item);
                    knapsack.size -= item.weight;
                    knapsack.itemCount++;
                }
            }
            return knapsack.ListOfItems;
        }
    }
}
