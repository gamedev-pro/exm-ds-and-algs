using System;
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
                GetSafe(testInput, 0);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished GetSafe: {afterMemory - beforeMemory}");
                GC.Collect();
            }

            {
                var beforeMemory = GC.GetTotalMemory(true);
                SumArray(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished SumArray: {afterMemory - beforeMemory}");
                GC.Collect();
            }

            {
                var beforeMemory = GC.GetTotalMemory(true);
                SumNested(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished SumNested: {afterMemory - beforeMemory}");
                GC.Collect();
            }

            {
                var beforeMemory = GC.GetTotalMemory(true);
                StringJoin(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished String Joing: {afterMemory - beforeMemory}");
                GC.Collect();
            }

            {
                var beforeMemory = GC.GetTotalMemory(true);
                CloneArray(testInput);
                var afterMemory = GC.GetTotalMemory(false);
                Console.WriteLine($"Finished CloneArray: {afterMemory - beforeMemory}");
                GC.Collect();
            }
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
        
        static int[] CloneArray(int[] arr)
        {	
            var newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }
    }
}
