using System;

namespace cS1
{
    internal class Program
    {
        public static int SumOfArray(int[] a)
        {
            int sum = 0;
            foreach (var x in a)
            {
                sum += x;
            }
            return sum;

        }



        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
                if (a[i].Length > 3)
                {
                    Console.Write(a[i] + " ");
                }
            }


        }



    }
}