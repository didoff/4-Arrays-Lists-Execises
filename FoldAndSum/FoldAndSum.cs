using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] foldLeft = new int[k];
            int[] foldRigt = new int[k];
            int[] rowLeft = new int[k];
            int[] rowRight = new int[k];

            for (int i = 0; i < k/2 - 1; i++)
            {
                foldLeft[i] = arr[i];
            }
            for (int i = k/2 - 1; i < k - 1; i++)
            {
                rowLeft[i] = arr[i];
            }
            for (int i = k - 1; i < 2*k - 1; i++)
            {
                rowLeft[i] = arr[i];
            }
            for (int i = 2*k - 1; i < 4*k - 1; i++)
            {
                foldRigt[i] = arr[i];
            }

            Console.WriteLine(string.Join(" ", foldLeft));
            Console.WriteLine(string.Join(" ", rowLeft));
            Console.WriteLine(string.Join(" ", rowRight));
            Console.WriteLine(string.Join(" ", foldRigt));

            // IndexOutOfRange Exception somewhere or everywhere..
        }
    }
}
