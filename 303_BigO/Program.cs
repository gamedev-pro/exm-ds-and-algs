using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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

            SpaceAnalysis(testInput);

            Console.ReadKey();
        }

        private static void SpaceAnalysis(int[] testInput)
        {
            {
                var beforeMemory = GC.GetTotalMemory(true);
                StringJoin(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished String Joing: {afterMemory - beforeMemory}");
            }

            {
                var beforeMemory = GC.GetTotalMemory(true);
                ContainsRepeatingNumber(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished ContainsRepeatingNumber: {afterMemory - beforeMemory}");
            }
        }

        static string StringJoin(int[] arr)
        {
            var stringBuilder = new StringBuilder(2 * arr.Length - 1);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                stringBuilder.Append(arr[i]);
                stringBuilder.Append(',');
            }
            stringBuilder.Append(arr[arr.Length - 1]);
            return stringBuilder.ToString();
        }

        static bool ContainsRepeatingNumber(int[] arr)
        {
            var set = new HashSet<int>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                {
                    return true;
                }
                set.Add(arr[i]);
            }
            return false;
        }
    }
}
