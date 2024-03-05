namespace KnapsackFreeCodeCamp
{
    internal class Knapsack(int capacity)
    {
        public int maxCapacity = capacity;

        public int Max_value(int numberOfItems, int[] weights, int[] values)
        {
            int[,] data = new int[numberOfItems + 1, maxCapacity + 1];

            for (int itemNum = 0; itemNum <= numberOfItems; itemNum++)
            {
                for (int capacity = 0; capacity <= maxCapacity; capacity++)
                {
                    // For the first row and collumn
                    if (itemNum == 0 || capacity == 0)
                    {
                        data[itemNum, capacity] = 0;
                    }
                    // Find the max value
                    else if (weights[itemNum] <= capacity)
                    {
                        data[itemNum, capacity] = Math.Max(values[itemNum] + data[itemNum - 1, capacity - weights[itemNum]],
                                                                             data[itemNum - 1, capacity]);
                    }
                    // Max value form previous row because weight doesn't fit capacity
                    else
                    {
                        data[itemNum, capacity] = data[itemNum - 1, capacity];
                    }
                }
            }
            return data[numberOfItems, maxCapacity];
        }


    }
}
