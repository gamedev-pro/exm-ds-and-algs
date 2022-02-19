// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

int GetRandom(int[] arr)
{
    var rnd = new System.Random();
    return arr[rnd.Next(0, arr.Length)];
}

int SumArray(int[] arr)
{
    var result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }
    return result;
}

int SumNested(int[] arr)
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

var testInput = new int[] { 10 };

var stopWatch = new Stopwatch();

stopWatch.Start();
GetRandom(testInput);
stopWatch.Stop();
Console.WriteLine($"Finished GetRandom: {stopWatch.Elapsed}");
stopWatch.Reset();

stopWatch.Start();
SumArray(testInput);
stopWatch.Stop();
Console.WriteLine($"Finished SumArray: {stopWatch.Elapsed}");
stopWatch.Reset();

stopWatch.Start();
SumNested(testInput);
stopWatch.Stop();
Console.WriteLine($"Finished SumNested: {stopWatch.Elapsed}");
stopWatch.Reset();