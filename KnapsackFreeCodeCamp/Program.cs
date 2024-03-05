namespace KnapsackFreeCodeCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* List of aviable items and their value:
             * 1 - Microwave - weight: 8, value: 50
             * 2 - Drone - weight: 2, value: 150
             * 3 - Monitor - weight: 6, value: 210
             * 4 - Kettle - weight: 1, value: 30
             * 
             * Total capacity of container is: 10
             */


            int[] weights = new int[] { 0, 8, 2, 6, 1 };
            int[] values = new int[] { 0, 50, 150, 210, 30 };

            // Stores the table made on paper
            int[,] data = new int[5, 11];


            const int numberOfItems = 4;

            const int maxCapacity = 10;

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

            Console.WriteLine($"Max value of items included in container: {data[numberOfItems, maxCapacity]}");
            Console.ReadKey();
        }
    }
}
