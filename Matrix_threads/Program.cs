namespace Matrix_threads
{
    internal class Program
    {
        public static volatile int count = 0;
        public static readonly object locker = new object();

        static void Main(string[] args)
        {
            int nThreads = 10;
            Thread[] threads = new Thread[nThreads];
            for (int i = 0; i < nThreads; i++) threads[i] = new Thread(Counting);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Thread t in threads) { t.Start(); }
            foreach (Thread t in threads) { t.Join(); }
            watch.Stop();
            Console.WriteLine($"{count} threads ended in {watch.ElapsedMilliseconds} ms.");



            Matrix myMatrix = new Matrix(5, 4);
            myMatrix.ToString();
        }

        static void Counting()
        {
            Thread.Sleep(500);
            lock (locker)
            {
                var tmp = count;
                Thread.Sleep(500);
                count = tmp + 1;
            }
        }
    }
}
