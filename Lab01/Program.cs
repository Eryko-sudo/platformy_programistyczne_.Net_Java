namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyUserInput = new UserInput();
            MyUserInput.GetUserInput();

             List<Item> randomList = new List<Item>();
             List<Item> result = new List<Item>();


            var MyKnapsack = new KnapsackProblem(MyUserInput.knapsackSize, MyUserInput.seed);
            randomList = KnapsackProblem.CreateRandomList(MyUserInput.itemCount, MyUserInput.seed);
            result = KnapsackProblem.SolveKnapsack(randomList, MyKnapsack);

            Item.PrintListContents(randomList);
            Item.PrintListContents(result);

            var MyResult = new Result(result);

            MyResult.PrintKnapsackContents();

        }
    }
}
