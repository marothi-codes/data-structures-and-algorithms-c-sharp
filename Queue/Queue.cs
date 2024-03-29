#nullable disable

namespace Queue;

public class Queue<T>
{
    private LinkedList<T> _list = new();

    /// <summary>
    /// Adds a new item to the end of the queue
    /// </summary>
    /// <param name="item">The item to add to the queue</param>
    public void Enqueue(T item)
    {
        _list.AddLast(item);
    }

    /// <summary>
    /// Removes the first item from the queue
    /// </summary>
    /// <returns>The removed queue item</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        T value = _list.First.Value;
        _list.RemoveFirst();
        return value;
    }

    /// <summary>
    /// Checks if the queue is empty
    /// </summary>
    /// <returns>A boolean indicating whether the queue is empty</returns>
    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    /// <summary>
    /// Clears the queue
    /// </summary>
    public void Clear()
    {
        _list.Clear();
    }

    /// <summary>
    /// Counts the number of items in the queue
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return _list.Count;
    }

    /// <summary>
    /// Prints all the items in the queue
    /// </summary>
    public void PrintQueue()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }
}
