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

            const int numberOfItems = 4;

            Knapsack aKnapsack = new Knapsack(10);

            int maxValue = aKnapsack.Max_value(numberOfItems, weights, values);

            Console.WriteLine($"Max value of items included in container: {maxValue}");
            Console.ReadKey();
        }
    }
}
