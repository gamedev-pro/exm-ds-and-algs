public static class FirstNonRepeatingCharacterChallenge
{
    // T: O(n^2), S: O(1)
    public static int FirstNonRepeatingCharacter_Naive(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            var foundDuplicate = false;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j] && i != j)
                {
                    foundDuplicate = true;
                }
            }
            if (!foundDuplicate)
            {
                return i;
            }
        }
        return -1;
    }

    // T O(n), S O(1)
    public static int FirstNonRepeatingCharacter(string str)
    {
        var charFreq = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            var c = str[i];
            if (charFreq.TryGetValue(c, out var freq))
            {
                charFreq[c] = freq + 1;
            }
            else
            {
                charFreq[c] = 1;
            }
        }
        for (int i = 0; i < str.Length; i++)
        {
            var character = str[i];
            if (charFreq[character] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}