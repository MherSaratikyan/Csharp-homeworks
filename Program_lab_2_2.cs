using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int numRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Enter the number of elements in row {i + 1}: ");
                int numElements = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[numElements];

                for (int j = 0; j < numElements; j++)
                {
                    jaggedArray[i][j] = Environment.TickCount;
                    Console.Write(jaggedArray[i][j] + "\t");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
            }
        }
    }
}
