using System;
using System.Collections.Generic;

namespace _322_Dictionary
{
    //Foi o desafio tecnico na Unity
    // Pediram com generics
    // A gente tem que implementar uma linked list tbm (especializada pro dictionary)
    public class MyDictionary
    {	
        // key -> value
        // array de buckets (linked lists internamente)
        // i = Hash(key) % array.Length
        // Os valores do Dictionary tem que manter uma referencia para a key (para a gente saber qual deles eh o certo na Linked List)
        // Tentar minimizar o tamanho da linked lists (tamanho)

        // Lookup, Add, Remove
        
        private struct Entry
        {
            public int Value;
            public int KeyHash;
        }

        private LinkedList<Entry>[] buckets;
        
        public MyDictionary(int capacity)
        {
            buckets = new LinkedList<Entry>[capacity * 2];
        }
        
        public int GetValue(string key)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if (bucket != null)
            {	
                // No pior caso eh O(n), mas a gente vai trabalhar para fazer essa lista ser muito pequena
                foreach (var entry in bucket)
                {
                    if (entry.KeyHash == hash)
                    {
                        return entry.Value;
                    }
                }
            }
            
            return -1;
        }
        
        public void Add(string key, int value)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if (bucket == null)
            {
                bucket = new LinkedList<Entry>();
                buckets[bucketIndex] = bucket;
            }

            bucket.AddLast(new Entry
            {
                Value = value,
                KeyHash = hash
            });
        }
        
        public void Remove(string key)
        {	
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if (bucket != null)
            {	
                foreach (var entry in bucket)
                {
                    if (entry.KeyHash == hash)
                    {
                        //TODO: Isso aqui ta O(n2)
                        bucket.Remove(entry);
                        break;
                    }
                }
            }
        }
    }
}
