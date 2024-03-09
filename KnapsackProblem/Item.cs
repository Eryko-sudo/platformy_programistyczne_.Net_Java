using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackTests")]

namespace KnapsackProblem
{
    internal class Item
    {
        public int value;
        public int weight;
        public int index;
        public Item(int value, int weight, int index)
        {
            this.value = value;
            this.weight = weight;
            this.index = index;
        }
    }
}
