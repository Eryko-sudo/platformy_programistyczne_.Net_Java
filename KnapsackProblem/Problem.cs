namespace KnapsackProblem
{
    internal class Problem
    {
        public int itemCount;
        public int seed;

        public List<Item> items = new List<Item>();

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
                int value = r.Next(1, 10);
                int weight = r.Next(1, 10);

                Item newItem = new Item(value, weight, i + 1);
                items.Add(newItem);

            }
        }

        public List<Item> Solve(int size)
        {
            List<Item>? solvedItems = null;

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
    }

}

