public static class RemoveDupesLinkedListChallenge
{
    public static LinkedList<int> RemoveDupesLinkedList(LinkedList<int> list)
    {
        var currentNode = list.First;
        while (currentNode != null)
        {
            var next = currentNode.Next;
            while (next != null &&
              next.Value == currentNode.Value)
            {
                list.Remove(next);
                next = currentNode.Next;
            }
            currentNode = next;
        }
        return list;
    }
}