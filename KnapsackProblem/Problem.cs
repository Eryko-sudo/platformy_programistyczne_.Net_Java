using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackTests"), InternalsVisibleTo("KnapsackGUI")]

namespace KnapsackProblem
{
    internal class Problem
    {
        public int itemCount;
        public int seed;

        public List<Item> items = new List<Item>();
        public List<Item> solvedItems = new List<Item>();


        public Problem(int itemCount, int seed)
        {
            this.itemCount = itemCount;
            this.seed = seed;
        }

        public void RandomizeProblem()
        {

            Random r = new Random(seed);

            for (int i = 0; i < itemCount; i++)
            {
                int weight = r.Next(1, 11);
                int value = r.Next(1, 11);

                Item newItem = new Item(value, weight, i + 1);
                items.Add(newItem);

            }
        }

        public List<Item> Solve(int size)
        {

            items.Sort((x, y) => (y.value * 1.0 / y.weight).CompareTo(x.value * 1.0 / x.weight)); // Overload

            foreach (var item in items)
            {
                if (size >= item.weight)
                {
                    solvedItems.Add(item);
                    size -= item.weight;
                }
            }
            return solvedItems;
        }

        public override string ToString()
        {
            string itemsInfo = " ";

            foreach (var item in items)
            {
                itemsInfo += $"Id: {item.index}, Value: {item.value}, Weight: {item.weight}";
                itemsInfo += Environment.NewLine;

            }

            return itemsInfo;
        }
    }

}

