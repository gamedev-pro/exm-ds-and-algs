public static class ValidateSubsequenceChallenge
{
    public static bool ValidateSubSequence(int[] arr, int[] sequence)
    {
        var currSeqIndex = 0;
        foreach (var val in arr)
        {
            if (sequence[currSeqIndex] == val)
            {
                currSeqIndex++;
            }
            if (currSeqIndex == sequence.Length)
            {
                break;
            }
        }
        return currSeqIndex == sequence.Length;
    }
}