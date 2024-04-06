using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
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

        //public static List<Item> CreateListOfItems(int numberOfItems, int seed)
        //{
        //    List<Item> listOfItems = new List<Item>();

        //    for (int i = 0; i < numberOfItems; i++)
        //    {
        //        Item newItem = new Item(seed + i, i+1); // Temporary fix
        //        listOfItems.Add(newItem);
        //    }

        //    return listOfItems;
        //}

        public static void PrintListContents(List<Item> list)
        {
            Console.WriteLine("List items:");
            foreach (var item in list)
            {
                Console.WriteLine($"Nr. {item.index}        Value: {item.value}      Weight: {item.weight}");
            }
        }
    }
}
