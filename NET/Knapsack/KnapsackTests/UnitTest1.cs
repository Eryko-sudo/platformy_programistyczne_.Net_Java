using KnapsackProblem;

namespace KnapsackTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AtLeastOneItemFound()
        {
            Problem problem = new Problem(5, 1);
            problem.RandomizeProblem();

            List<Item> result = problem.Solve(10);

            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void EmptyItemListReturnsEmptySolution()
        {
            Problem problem = new Problem(0, 1);

            List<Item> result = problem.Solve(10);

            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void KnapsackSizeLessThanMinimumWeightReturnsEmptySolution()
        {
            Problem problem = new Problem(3, 1);
            problem.items = new List<Item>
            {
            new(1, 10, 1),
            new(2, 20, 2),
            new(4, 30, 3)
            };

            List<Item> result = problem.Solve(3);

            Assert.IsTrue(result.Count == 0);
        }



        [TestMethod]
        public void KnapsackSizeEqualZeroReturnsEmptySolution()
        {
            Problem problem = new Problem(5, 1);
            problem.RandomizeProblem();

            List<Item> result = problem.Solve(0);

            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void OrderOfItemsDoesNotAffectSolution()
        {
            Problem problem1 = new Problem(5, 1);
            Problem problem2 = new Problem(5, 1);
            problem1.RandomizeProblem();
            problem2.RandomizeProblem();

            List<Item> result1 = problem1.Solve(5);
            List<Item> result2 = problem2.Solve(5);

            Assert.IsTrue(result1.Count == result2.Count);
        }

        [TestMethod]
        public void IncreasingKnapsackSizeReturnsMoreItems()
        {
            Problem problem1 = new Problem(5, 1);
            problem1.RandomizeProblem();
            Problem problem2 = new Problem(5, 1);
            problem2.RandomizeProblem();

            Result result1 = new Result(problem1.Solve(5));
            Result result2 = new Result(problem2.Solve(20));

            Assert.IsTrue(result2.resultItems.Count > result1.resultItems.Count);
        }

        [TestMethod]
        public void AllItemsEqualValueAndWeightReturnsAllItems()
        {
            Problem problem = new Problem(3, 123);
            problem.items = new List<Item>
            {
                new(5, 5, 1),
                new(5, 5, 2),
                new(5, 5, 3)
            };

            List<Item> result = problem.Solve(15);

            Assert.IsTrue(result.Count == 3);
        }



        [TestMethod]
        public void AnInstanceReturnsACorrectSolution()
        {
            Problem problem = new Problem(5, 1);
            problem.items = new List<Item>
            {
                new(3, 2, 1),
                new(4, 3, 2),
                new(2, 2, 3),
                new(5, 6, 4),
                new(1, 1, 5)
            };

            List<Item> result = problem.Solve(7);

            Assert.IsTrue(result.Count == 3);
        }
    }
}