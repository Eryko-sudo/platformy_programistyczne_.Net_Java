using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_threads
{
    internal class Matrix
    {
        public int[,] data;
        public Matrix(int rows, int columns) {
            data = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = random.Next(10);
                }
            }
        
        }

        public void ToString()
        {
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);

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
