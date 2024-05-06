using System.Diagnostics;

namespace Matrix_threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;    
            int tryCount = 3;

            int[] nThreadsList = { 1, 2, 4, 8 };
            TimeSpan[] threadSum = new TimeSpan[nThreadsList.Length];
            TimeSpan[] parallelSum = new TimeSpan[nThreadsList.Length];
            TimeSpan[] threadTime = new TimeSpan[nThreadsList.Length];
            TimeSpan[] parallelTime = new TimeSpan[nThreadsList.Length];

            for (int j = 0; j < nThreadsList.Length; j++)
            {
                int nThreads = nThreadsList[j];
                for (int i = 0; i < tryCount; i++)
                {

                    Matrix A = new Matrix(x, x);
                    Matrix B = new Matrix(x, x);

                    Matrix C = new Matrix(A.rows, B.columns);
                    Matrix D = new Matrix(A.rows, B.columns);

                    var watch_threads = Stopwatch.StartNew();
                    C.data = Matrix.Multiply_threads(A, B, nThreads);
                    watch_threads.Stop();

                    threadSum[j] += watch_threads.Elapsed;

                    var watch_parallel = Stopwatch.StartNew();
                    D.data = Matrix.Multiply_parallel(A, B, nThreads);
                    watch_parallel.Stop();

                    parallelSum[j] += watch_parallel.Elapsed;
                }

                threadTime[j] = TimeSpan.FromMilliseconds(threadSum[j].TotalMilliseconds / tryCount);
                parallelTime[j] = TimeSpan.FromMilliseconds(parallelSum[j].TotalMilliseconds / tryCount);
            }
            Console.WriteLine($"Results of multiplication of {x} by {x} matrices: ");
            Console.WriteLine("Threads\tThreads Time (ms)\tParallel Time (ms)");

            for (int k = 0; k < nThreadsList.Length; k++)
            {
                Console.WriteLine($"{nThreadsList[k]}\t{threadTime[k].TotalMilliseconds}\t\t\t{parallelTime[k].TotalMilliseconds}");
            }
        }
    }
}
