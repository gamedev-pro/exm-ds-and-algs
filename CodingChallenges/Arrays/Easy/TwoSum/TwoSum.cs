public static class TwoSumChallenge
{
    // T: O(n^2), S: O(1)
    public static int[] TwoSum_Naive(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[0];
    }

    // T: O(n), S: O(n)
    public static int[] TwoSum(int[] arr, int target)
    {
        var valuesToIndexes = new Dictionary<int, int>(arr.Length);
        for (int i = 0; i < arr.Length; i++)
        {
            var currentValue = arr[i];
            var candidate = target - currentValue;
            if (valuesToIndexes.ContainsKey(candidate))
            {
                var j = valuesToIndexes[candidate];
                return new int[] { j, i };
            }
            else
            {
                valuesToIndexes.Add(currentValue, i);
            }
        }
        return new int[0];
    }
}