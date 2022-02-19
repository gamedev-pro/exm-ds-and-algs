using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace _303_BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var testInput = new int[] { 10 }; */
            /* var testInput = Enumerable.Range(0, 1000).ToArray(); */
            var testInput = Enumerable.Range(0, 10_000).ToArray();
            /* var testInput = Enumerable.Range(0, 100_000).ToArray(); */

            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                GetSafe(testInput, 0);
                stopWatch.Stop();
                Console.WriteLine($"Finished GetRandom: {stopWatch.Elapsed}");
            }

            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                SumArray(testInput);
                stopWatch.Stop();
                Console.WriteLine($"Finished SumArray: {stopWatch.Elapsed}");
            }

            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                SumNested(testInput);
                stopWatch.Stop();
                Console.WriteLine($"Finished SumNested: {stopWatch.Elapsed}");
            }

            Console.ReadKey();
        }

        static int GetSafe(int[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }
            return -1;
        }

        static int SumArray(int[] arr)
        {
            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }

        static int SumNested(int[] arr)
        {
            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += i;
                for (int j = 0; j < arr.Length; j++)
                {
                    result += j;
                }
            }

            return result;
        }
    }
}
