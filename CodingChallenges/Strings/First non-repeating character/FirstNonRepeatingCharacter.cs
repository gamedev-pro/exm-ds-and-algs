public static class FirstNonRepeatingCharacterChallenge
{
    public static int FirstNonRepeatingCharacter(string str)
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
}