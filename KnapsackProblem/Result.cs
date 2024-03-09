namespace KnapsackProblem
{
    internal class Result
    {
        public int totalValue;
        public int totalWeight;
        public List<Item> solvedItems = new List<Item>();

        public Result(List<Item> list)
        {

            solvedItems = list;

            foreach (var item in solvedItems)
            {
                totalValue += item.value;
                totalWeight += item.weight;
            }
        }

        public override string ToString()
        {
            string itemsInfo = "Items in knapsack:\n";
            foreach (var item in solvedItems)
            {
                itemsInfo += $"Id: {item.index}, Value: {item.value}, Weight: {item.weight}\n";
            }

            itemsInfo += $"Total Value: {totalValue}, Total Weight: {totalWeight}";

            return itemsInfo;
        }

    }
}
