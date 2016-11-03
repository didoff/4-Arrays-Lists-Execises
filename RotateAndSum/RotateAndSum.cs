using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());

            int[] rotationSum = new int[arr.Length];

            for (int i = 0; i < rotationTimes; i++)
            {
                int lastElement = arr[arr.Length - 1];

                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[0] = lastElement;


                for (int k = 0; k < arr.Length; k++)
                {
                    rotationSum[k] += arr[k];
                }

            }

            Console.WriteLine(string.Join(" ", rotationSum));

        }
    }
}
