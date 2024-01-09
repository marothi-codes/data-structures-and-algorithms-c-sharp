#nullable disable

namespace HashTable;

public class HashTable<TKey, TValue>
{
    private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

    public HashTable(int size)
    {
        buckets = new LinkedList<KeyValuePair<TKey, TValue>>[size];
    }

    public void Add(TKey key, TValue value)
    {
        int bucket = GetBucket(key);
        if (buckets[bucket] == null)
            buckets[bucket] = new LinkedList<KeyValuePair<TKey, TValue>>();

        buckets[bucket].AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public bool Remove(TKey key)
    {
        int bucket = GetBucket(key);
        var node = Find(key);
        if (node != null)
        {
            buckets[bucket].Remove(node);
            return true;
        }
        return false;
    }

    public TValue Get(TKey key)
    {
        var node = Find(key);
        if (node != null)
            return node.Value.Value;
        return default;
    }

    public void PrintHashTable()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] != null)
            {
                foreach (var keyValuePair in buckets[i])
                {
                    Console.WriteLine($"Key: {keyValuePair.Key}, Value: {keyValuePair.Value}");
                }
            }
        }
    }

    private LinkedListNode<KeyValuePair<TKey, TValue>> Find(TKey key)
    {
        int bucket = GetBucket(key);
        if (buckets[bucket] != null)
        {
            for (var node = buckets[bucket].First; node != null; node = node.Next)
            {
                if (node.Value.Key.Equals(key))
                    return node;
            }
        }
        return null;
    }

    private int GetBucket(TKey key)
    {
        return Math.Abs(key.GetHashCode()) % buckets.Length;
    }
}
