using System;
using System.Linq;

namespace ArraysAndLists_Exercises
{
    class ArraysAndLists_Exercises
    {
        static void Main(string[] args)
        {
            string[] inputA = Console.ReadLine().Split(' ').ToArray();
            string[] inputB = Console.ReadLine().Split(' ').ToArray();
            
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < Math.Min(inputA.Length, inputB.Length); i++)
            {
                if (inputA[i] == inputB[i])
                {
                    count1++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(inputA);
            Array.Reverse(inputB);

            for (int j = 0; j < Math.Min(inputA.Length, inputB.Length); j++)
            {
                if (inputA[j] == inputB[j])
                {
                    count2++;
                }
                else
                {
                    break;
                }
            }

            if(count1 != 0)
                Console.WriteLine(count1);
            else
                Console.WriteLine(count2);

            
        }
    }
}
