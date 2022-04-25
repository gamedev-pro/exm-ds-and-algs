public static class NumberOfRecentCallsChallenge
{
    public static int NumberOfRecentCalls(Queue<int> ops, int t)
    {
        var counter = 0;
        while (ops.Count > 0)
        {
            var opTime = ops.Dequeue(); 
            if (opTime <= t)
            {
                counter++;
            }
        }
        return counter;
    }
}