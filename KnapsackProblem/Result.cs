using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackTests")]

namespace KnapsackProblem
{
    internal class Result
    {
        public int totalValue;
        public int totalWeight;
        public List<Item> resultItems = new List<Item>();

        public Result(List<Item> list)
        {

            resultItems = list;

            foreach (var item in resultItems)
            {
                totalValue += item.value;
                totalWeight += item.weight;
            }
        }

        public override string ToString()
        {
            string itemsInfo = "Items in knapsack:\n";
            foreach (var item in resultItems)
            {
                itemsInfo += $"Id: {item.index}, Value: {item.value}, Weight: {item.weight}\n";
            }

            itemsInfo += $"Total Value: {totalValue}, Total Weight: {totalWeight}";

            return itemsInfo;
        }

    }
}
