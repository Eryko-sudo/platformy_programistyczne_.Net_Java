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

            Problem problem = new Problem(5, 1);
            problem.items = new List<Item>
            {
                new(2, 1, 1),
                new(1, 4, 2),
                new(3, 3, 3),
                new(5, 8, 4),
                new(10, 1, 5)
            };

            var result1 = new Result(problem.Solve(1));
            var result2 = new Result(problem.Solve(20));
        }
    }
}
