#nullable disable

namespace Dictionary;

/// <summary>
/// Represents a key/value pair in a dictionary.
/// </summary>
/// <typeparam name="TKey">The type of the key in the pair.</typeparam>
/// <typeparam name="TValue">The type of the value in the pair.</typeparam>
public class KeyValuePair<TKey, TValue>
{
    /// <summary>
    /// Gets or sets the key in the pair.
    /// </summary>
    public TKey Key { get; set; }

    /// <summary>
    /// Gets or sets the value in the pair.
    /// </summary>
    public TValue Value { get; set; }
}
