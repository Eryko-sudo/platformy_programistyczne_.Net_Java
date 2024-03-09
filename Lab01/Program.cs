namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyUserInput = new UserInput();
            MyUserInput.GetUserInput();

             List<Item> temp = new List<Item>();
             List<Item> result = new List<Item>();


            var MyKnapsack = new KnapsackProblem(MyUserInput.knapsackSize, MyUserInput.seed);
            temp = KnapsackProblem.CreateRandomList(MyUserInput.itemCount, MyUserInput.seed);
            result = KnapsackProblem.SolveKnapsack(temp, MyKnapsack);

            Item.PrintListContents(temp);
            Item.PrintListContents(result);

            var MyResult = new Result(result);

            //MyResult.PrintKnapsackContents(MyKnapsack);
        }
    }
}
