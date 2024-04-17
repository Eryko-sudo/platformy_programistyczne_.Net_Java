namespace Matrix_threads
{
    internal class Matrix
    {
        public int[,] data;
        public int rows;
        public int columns;

        public Matrix(int numRows, int numColumns)
        {
            data = new int[numRows, numColumns];
            rows = numRows;
            columns = numColumns;
            InitializeMatrix();
        }

        private void InitializeMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = random.Next(10);
                }
            }
        }

        public static int[,] Multiply_threads(Matrix A, Matrix B, int nThreads)
        {
            if (A.columns != B.rows)
            {
                throw new ArgumentException("Incompatible matrix size!");
            }
            int[,] result = new int[A.rows, B.columns];
            Thread[] threads = new Thread[nThreads];
            int index = 0;
            int rowsPerThread = A.rows / nThreads;
            int remainingRows = A.rows % nThreads;
            int startingRow = 0;
            for (int i = 0; i < nThreads; i++)
            {
                int rowCount = rowsPerThread + (i < remainingRows ? 1 : 0);
                threads[index] = new Thread((object obj) =>
                {
                    Tuple<int, int, int> parameters = (Tuple<int, int, int>)obj;
                    int start = parameters.Item1;
                    int end = parameters.Item2;
                    int threadIndex = parameters.Item3;
                    for (int w = start; w < end; w++)
                    {
                        for (int j = 0; j < B.columns; j++)
                        {
                            int sum = 0;
                            for (int k = 0; k < A.columns; k++)
                            {
                                sum += A.data[w, k] * B.data[k, j];
                            }
                            lock (result)
                            {
                                result[w, j] = sum;
                            }
                        }
                    }
                });
                threads[index].Start(new Tuple<int, int, int>(startingRow, startingRow + rowCount, i));
                startingRow += rowCount;
                index++;
            }
            foreach (Thread thread in threads)
            {
                if (thread != null)
                {
                    thread.Join();
                }
            }
            return result;
        }


        public static int[,] Multiply_parallel(Matrix A, Matrix B, int nThreads)
        {
            if (A.columns != B.rows)
            {
                throw new ArgumentException("Incompatible matrix size!");
            }

            int[,] result = new int[A.rows, B.columns];
            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = nThreads
                //MaxDegreeOfParallelism = Environment.ProcessorCount
            };

            Parallel.For(0, A.rows, i =>
            {
                for (int j = 0; j < B.columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < A.columns; k++)
                    {
                        sum += A.data[i, k] * B.data[k, j];
                    }
                    result[i, j] = sum;
                }
            });

            return result;
        }


        public void ToString()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
