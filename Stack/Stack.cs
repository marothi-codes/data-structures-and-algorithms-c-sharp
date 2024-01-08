#nullable disable

namespace Stack;

public class Stack<T>
{
    private readonly LinkedList<T> _list = new();

    /// <summary>
    /// Adds a new item to the top of the stack
    /// </summary>
    /// <param name="value">The value to add to the top of the stack</param>
    public void Push(T value)
    {
        _list.AddFirst(value);
    }

    /// <summary>
    /// Removes the item from the top of the stack
    /// </summary>
    /// <returns>The value to remove</returns>
    /// <exception cref="InvalidOperationException">The exception is triggered when the stack is empty</exception>
    public T Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("The Stack is empty.");

        T value = _list.First.Value;
        _list.RemoveFirst();
        return value;
    }

    /// <summary>
    /// Views the item at the top of the stack without removing it
    /// </summary>
    /// <returns>The item at the top of the stack</returns>
    /// <exception cref="InvalidOperationException">The exception is triggered when the stack is empty</exception>
    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("The Stack is empty.");

        return _list.First.Value;
    }

    /// <summary>
    /// Checks if the stack is empty
    /// </summary>
    /// <returns>Whether the stack is empty</returns>
    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    /// <summary>
    /// Returns the number of items in the stack
    /// </summary>
    /// <returns>The number of items in the stack</returns>
    public int Count()
    {
        return _list.Count;
    }

    /// <summary>
    /// Prints all items in the stack
    /// </summary>
    public void PrintStack()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Clears the stack
    /// </summary>
    public void Clear()
    {
        _list.Clear();
    }
}
