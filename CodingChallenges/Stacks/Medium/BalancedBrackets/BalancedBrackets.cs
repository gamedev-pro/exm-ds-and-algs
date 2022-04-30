public static class BalancedBracketsChallenge
{
    public static bool BalancedBrackets(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        var stack = new Stack<char>(s.Length / 2);
        foreach (var c in s)
        {
            if (c == '(')
            {
                stack.Push(')');
            }
            else if (c == '[')
            {
                stack.Push(']');
            }
            else if (c == '{')
            {
                stack.Push('}');
            }
            else if (stack.Count > 0)
            {
                if (stack.Peek() == c)
                {
                    stack.Pop();
                }
            }
        }

        return stack.Count == 0 ? true : false;
    }
    
}
