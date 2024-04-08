namespace Matrix_threads
{
    internal class Program
    {
        public static volatile int count = 0;
        public static readonly object locker = new object();

        static void Main(string[] args)
        {
            int nThreads = 4;
            Matrix A = new Matrix(5, 16);
            Matrix B = new Matrix(16, 5);

            Matrix C = new Matrix(A.rows, B.columns);
            Matrix D = new Matrix(A.rows, B.columns);
            var watch_threads = System.Diagnostics.Stopwatch.StartNew();
            C.data = Matrix.Multiply_threads(A, B, nThreads);
            watch_threads.Stop();

            var watch_parallel = System.Diagnostics.Stopwatch.StartNew();
            D.data = Matrix.Multiply_parallel(A, B, nThreads);
            watch_parallel.Stop();

            //Console.WriteLine("Matrix A ------------------------------------");
            //A.ToString();
            //Console.WriteLine("Matrix B ------------------------------------");
            //B.ToString();
            Console.WriteLine("Matrix C ------------------------------------");
            C.ToString();
            Console.WriteLine("Matrix D ------------------------------------");
            D.ToString();

            Console.WriteLine($"{nThreads} threads for threads ended in {watch_threads.ElapsedMilliseconds} ms.");
            Console.WriteLine($"{nThreads} threads for parallel ended in {watch_parallel.ElapsedMilliseconds} ms.");

        }
    }
}
