using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackTests"), InternalsVisibleTo("KnapsackGUI")]

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
            string itemsInfo = " ";

            foreach (var item in resultItems)
            {
                itemsInfo += $"Id: {item.index}, Value: {item.value}, Weight: {item.weight}";
                itemsInfo += Environment.NewLine;
            }



            return itemsInfo;
        }

/*        public string PrintTotalWeight()
        {
            return $"{totalWeight}";
        }

        public string PrintTotalValue()
        {
            return $"{totalValue}";

        }*/
    }
}
