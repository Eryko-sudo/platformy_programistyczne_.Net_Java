namespace KnapsackProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int itemCount = 10;
            int seed = 1;
            int KnapsackSize = 10;

            var MyProblem = new Problem(itemCount, seed);
            MyProblem.RandomizeProblem();
            var MyResult = new Result(MyProblem.Solve(KnapsackSize));

            Console.WriteLine(MyProblem.ToString());
            Console.WriteLine(MyResult.ToString());

        }
    }
}
