#nullable disable

namespace LinkedList;

public class LinkedList<T>
{
	public Node<T> Head { get; private set; }
	public Node<T> Tail { get; private set; }

	// Insertion at the beginning
	public void AddFirst(T value)
	{
		var node = new Node<T>(value);
		node.Next = Head;
		Head = node;

		if (Tail == null)
		{
			Tail = Head;
		}
	}

	// Insertion at the end
	public void AddLast(T value)
	{
		var node = new Node<T>(value);

		if (Tail == null)
		{
			Head = node;
			Tail = node;
		}
		else
		{
			Tail.Next = node;
			Tail = node;
		}
	}

	// Insertion at a specific position
	public void AddAt(int index, T value)
	{
		if (index == 0)
		{
			AddFirst(value);
			return;
		}

		var current = Head;

		for (int i = 0; i < index - 1; i++)
		{
			if (current == null)
				throw new IndexOutOfRangeException();

			current = current.Next;
		}

		var node = new Node<T>(value);
		node.Next = current.Next;
		current.Next = node;
	}

	// Deletion of a specific value
	public bool Remove(T value)
	{
		if (Head == null)
		{
			return false;
		}

		if (Head.Value.Equals(value))
		{
			Head = Head.Next;
			return true;
		}

		var current = Head;
		while (current.Next != null)
		{
			if (current.Next.Value.Equals(value))
			{
				current.Next = current.Next.Next;
				return true;
			}
			current = current.Next;
		}

		return false;
	}

	// Traversal
	public void PrintAllNodes()
	{
		var current = Head;
		while (current != null)
		{
			Console.WriteLine(current.Value);
			current = current.Next;
		}
	}

	// Search
	public Node<T> Find(T value)
	{
		var current = Head;
		while (current != null)
		{
			if (current.Value.Equals(value))
			{
				return current;
			}
			current = current.Next;
		}
		return null;
	}

	// Access by index
	public T Get(int index)
	{
		var current = Head;
		for (int i = 0; i < index; i++)
		{
			if (current == null)
				throw new IndexOutOfRangeException();

			current = current.Next;
		}
		return current.Value;
	}
}
