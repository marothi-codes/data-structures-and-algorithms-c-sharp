#nullable disable

namespace Dictionary;

public class DictionaryImplementation<T, U>
{
    private readonly List<KeyValuePair<T, U>> _list;

    public DictionaryImplementation()
    {
        _list = new List<KeyValuePair<T, U>>();
    }

    public void Add(T key, U value)
    {
        if (ContainsKey(key))
        {
            throw new ArgumentException(
                "An element with the same key already exists in the dictionary."
            );
        }
        _list.Add(new KeyValuePair<T, U> { Key = key, Value = value });
    }

    public void Remove(T key)
    {
        var item =
            _list.SingleOrDefault(x => EqualityComparer<T>.Default.Equals(x.Key, key))
            ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
        _list.Remove(item);
    }

    public U this[T key]
    {
        get
        {
            var item =
                _list.SingleOrDefault(x => EqualityComparer<T>.Default.Equals(x.Key, key))
                ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
            return item.Value;
        }
        set
        {
            var item =
                _list.SingleOrDefault(x => EqualityComparer<T>.Default.Equals(x.Key, key))
                ?? throw new KeyNotFoundException("The key does not exist in the dictionary.");
            item.Value = value;
        }
    }

    public bool ContainsKey(T key)
    {
        return _list.Any(x => EqualityComparer<T>.Default.Equals(x.Key, key));
    }
}
