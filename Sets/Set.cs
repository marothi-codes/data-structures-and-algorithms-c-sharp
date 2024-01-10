#nullable disable

using System.Collections.Generic;

namespace Sets;
public class Set<T>
{
	private readonly Dictionary<T, int> _set;

	public Set()
	{
		_set = new Dictionary<T, int>();
	}

	// Insertion (Add)
	public void Add(T item)
	{
		if (!_set.ContainsKey(item))
		{
			_set.Add(item, 0);
		}
	}

	// Deletion (Remove)
	public void Remove(T item)
	{
		if (_set.ContainsKey(item))
		{
			_set.Remove(item);
		}
	}

	// Search (Contains)
	public bool Contains(T item)
	{
		return _set.ContainsKey(item);
	}

	// Size (Count)
	public int Count()
	{
		return _set.Count;
	}

	// Iteration (Enumerate)
	public IEnumerable<T> Enumerate()
	{
		foreach (var item in _set.Keys)
		{
			yield return item;
		}
	}
}
