using System.Text;

public static class PalindromeChallenge
{
    public static bool Palindrome_1(string str)
    {
        var reversedstring = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedstring.Append(str[i]);
        }
        return str.Equals(reversedstring.ToString());
    }

    public static bool Palindrome(string str)
    {
        var leftIndex = 0;
        var rightIndex = str.Length - 1;
        while (leftIndex < rightIndex)
        {
            if (str[leftIndex] != str[rightIndex])
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }
}