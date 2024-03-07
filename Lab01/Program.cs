namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyUserInput = new UserInput();
            MyUserInput.GetUserInput();

            var MyKnapsack = new KnapsackProblem(MyUserInput.knapsackSize, MyUserInput.seed);
            var MyResult = new Result(KnapsackProblem.SolveKnapsack(KnapsackProblem.CreateRandomList(MyUserInput.itemCount, MyUserInput.seed), MyKnapsack));

            //MyResult.PrintKnapsackContents(MyKnapsack);
        }
    }
}
