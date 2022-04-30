using System;

namespace _322_Dictionary
{
    public struct ItemInstance
    {
        public string Name;
        public int Count;
    }
    public static class Program
    {	
        public static void Main(string[] args)
        {
            var dict = new MyDictionaryGeneric<string, int>(10);

            dict.Add("item_1", 2);
            dict.Add("item_2", 3);
            dict.Add("item_3", 4);
            dict.Add("item_4", 5);

            Console.WriteLine(dict.GetValue("item_1"));
            Console.WriteLine(dict.GetValue("item_2"));
            Console.WriteLine(dict.GetValue("unexisting item"));

            dict.Remove("item_2");
            Console.WriteLine(dict.GetValue("item_2"));

            Console.ReadKey();
        }
    }
}
