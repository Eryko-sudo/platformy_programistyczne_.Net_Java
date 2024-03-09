using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
