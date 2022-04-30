using System;
using System.Collections.Generic;

namespace _322_Dictionary
{
    public class MyDictionaryGeneric<TKey, TValue>
    {	
        private struct Entry
        {
            public TValue Value;
            public int KeyHash;
        }

        private LinkedList<Entry>[] buckets;
        
        public MyDictionaryGeneric(int capacity)
        {
            buckets = new LinkedList<Entry>[capacity * 2];
        }
        
        public TValue GetValue(TKey key)
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

            /* throw new Exception($"Couldn't find value for key {key}"); */
            return default(TValue);
        }
        
        public void Add(TKey key, TValue value)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if (bucket == null)
            {
                bucket = new LinkedList<Entry>();
                buckets[bucketIndex] = bucket;
            }
            
            //TODO: if bucket.Count > N, expandir array buckets

            bucket.AddLast(new Entry
            {
                Value = value,
                KeyHash = hash
            });
        }
        
        public void Remove(TKey key)
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
