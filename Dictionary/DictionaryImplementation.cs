#nullable disable

namespace Dictionary;

public class DictionaryImplementation<TKey, TValue>
{
    /// <summary>
    /// The list that stores the key-value pairs.
    /// </summary>
    private readonly List<KeyValuePair<TKey, TValue>> _list;

    /// <summary>
    /// Initializes a new instance of the DictionaryImplementation class.
    /// </summary>
    public DictionaryImplementation()
    {
        _list = new List<KeyValuePair<TKey, TValue>>();
    }

    /// <summary>
    /// Adds a key-value pair to the dictionary.
    /// </summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value of the element to add.</param>
    /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary.</exception>
    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
        {
            throw new ArgumentException(
                "An element with the same key already exists in the dictionary."
            );
        }
        _list.Add(new KeyValuePair<TKey, TValue> { Key = key, Value = value });
    }

    /// <summary>
    /// Removes the element with the specified key from the dictionary.
    /// </summary>
    /// <param name="key">The key of the element to remove.</param>
    /// <exception cref="KeyNotFoundException">The key does not exist in the dictionary.</exception>
    public void Remove(TKey key)
    {
        var item =
            _list.SingleOrDefault(x => EqualityComparer<TKey>.Default.Equals(x.Key, key))
            ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
        _list.Remove(item);
    }

    /// <summary>
    /// Gets or sets the value associated with the specified key.
    /// </summary>
    /// <param name="key">The key of the value to get or set.</param>
    /// <exception cref="KeyNotFoundException">The key does not exist in the dictionary.</exception>
    public TValue this[TKey key]
    {
        get
        {
            var item =
                _list.SingleOrDefault(x => EqualityComparer<TKey>.Default.Equals(x.Key, key))
                ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
            return item.Value;
        }
        set
        {
            var item =
                _list.SingleOrDefault(x => EqualityComparer<TKey>.Default.Equals(x.Key, key))
                ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
            item.Value = value;
        }
    }

    /// <summary>
    /// Determines whether the dictionary contains an element with the specified key.
    /// </summary>
    /// <param name="key">The key to locate in the dictionary.</param>
    /// <returns>true if the dictionary contains an element with the key; otherwise, false.</returns>
    public bool ContainsKey(TKey key)
    {
        return _list.Any(x => EqualityComparer<TKey>.Default.Equals(x.Key, key));
    }
}
