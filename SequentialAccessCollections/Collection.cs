#nullable disable

using System.Collections;

namespace SequentialAccessCollections;

public class Collection : CollectionBase
{
    /// <summary>
    /// Add a new item to the collection
    /// </summary>
    /// <param name="item">The item to add</param>
    public void Add(object item)
    {
        InnerList.Add(item);
    }

    /// <summary>
    /// Removes an item from the collection
    /// </summary>
    /// <param name="item">The item to remove</param>
    public void Remove(object item)
    {
        InnerList.Remove(item);
    }

    /// <summary>
    /// Clears the collection
    /// </summary>
    public new void Clear()
    {
        InnerList.Clear();
    }

    /// <summary>
    /// Counts the number of items in the collection
    /// </summary>
    /// <returns>The number of items in the collection</returns>
    public new int Count()
    {
        return InnerList.Count;
    }

    /// <summary>
    /// Retrieves the specified item from the collection
    /// </summary>
    /// <param name="item">The item to retrieve</param>
    /// <returns></returns>
    public object Get(object item)
    {
        int index = InnerList.IndexOf(item);
        return InnerList[index];
    }

    #region Sorting Algorithms

    /// <summary>
    /// Sorts the collection using the Bubble Sort Algorithm
    /// </summary>
    public void BubbleSort()
    {
        int upper = Count() - 1;
        object temp;

        for (int outer = upper; outer >= 1; outer--)
        {
            for (int inner = 0; inner <= outer - 1; inner++)
            {
                if ((int)InnerList[inner] > (int)InnerList[inner + 1])
                {
                    temp = InnerList[inner];
                    InnerList[inner] = InnerList[inner + 1];
                    InnerList[inner + 1] = temp;
                }
            }
        }
    }

    /// <summary>
    /// Sorts the collection using the Selection Sort Algorithm
    /// </summary>
    public void SelectionSort()
    {
        int upper = Count() - 1;
        int min;
        object temp;

        for (int outer = 0; outer <= upper; outer++)
        {
            min = outer;

            for (int inner = outer + 1; inner <= upper; inner++)
            {
                if ((int)InnerList[inner] < (int)InnerList[min])
                    min = inner;
            }

            temp = InnerList[outer];
            InnerList[outer] = InnerList[min];
            InnerList[min] = temp;
        }
    }

    /// <summary>
    /// Sorts the collection using the Shell Sort Algorithm
    /// </summary>
    public void ShellSort()
    {
        int i,
            j,
            increment,
            temp;
        increment = 3;

        while (increment > 0)
        {
            for (i = 0; i < InnerList.Count; i++)
            {
                j = i;
                temp = (int)InnerList[i];

                while ((j >= increment) && ((int)InnerList[j - increment] > temp))
                {
                    InnerList[j] = InnerList[j - increment];
                    j -= increment;
                }

                InnerList[j] = temp;
            }

            if (increment / 2 != 0)
                increment /= 2;
            else if (increment == 1)
                increment = 0;
            else
                increment = 1;
        }
    }

    /// <summary>
    /// Sorts the collections using the Quick Sort Algorithm
    /// </summary>
    public void QuickSort()
    {
        QuickSortHelper(0, Count() - 1);
    }

    /// <summary>
    /// Sorts the collections using the Merge Sort Algorithm
    /// </summary>
    public void MergeSort()
    {
        if (Count() > 1)
        {
            int mid = Count() / 2;
            Collection left = new();
            Collection right = new();

            for (int i = 0; i < mid; i++)
            {
                left.Add(InnerList[i]);
            }

            for (int i = mid; i < Count(); i++)
            {
                right.Add(InnerList[i]);
            }

            left.MergeSort();
            right.MergeSort();

            Merge(left, right);
        }
    }

    #endregion

    #region Search Algorithms

    /// <summary>
    /// Searches the collection for the specified item using the sequential search algorithm
    /// </summary>
    public bool SequentialSearch(int sValue)
    {
        for (int i = 0; i < InnerList.Count - 1; i++)
            if ((int)InnerList[i] == sValue)
                return true;
        return false;
    }

    /// <summary>
    /// Searches for the specified item using the BinarySearch algorithm
    /// </summary>
    /// <param name="value">The item to search for</param>
    /// <returns>The index of the item if found in the collection. -1 if otherwise.</returns>
    public int BinarySearch(int value)
    {
        int end,
            start,
            mid;
        end = InnerList.Count - 1;
        start = 0;

        while (start <= end)
        {
            mid = (end + start) / 2;
            if ((int)InnerList[mid] == value)
                return mid;
            else if (value < (int)InnerList[mid])
                end = mid - 1;
            else
                start = mid + 1;
        }
        return -1;
    }

    /// <summary>
    /// Searches for the specified item using the Recursive Binary Search algorithm
    /// </summary>
    /// <param name="search">The item to search for</param>
    /// <param name="lower">The lower bound of the search</param>
    /// <param name="upper">The upper bound of the search</param>
    /// <returns>The index position of the searched item</returns>
    public int RecursiveBinarySearch(int search, int lower, int upper)
    {
        if (lower <= upper)
        {
            int mid;
            mid = (upper + lower) / 2;

            if (search < (int)InnerList[mid])
                return RecursiveBinarySearch(search, lower, mid - 1);
            else if (search == (int)InnerList[mid])
                return mid;
            else
                return RecursiveBinarySearch(search, mid + 1, upper);
        }
        else
            return -1;
    }

    #endregion

    #region Helper Methods

    private void Merge(Collection left, Collection right)
    {
        InnerList.Clear();

        while (left.Count() > 0 && right.Count() > 0)
        {
            if ((int)left.InnerList[0] <= (int)right.InnerList[0])
            {
                InnerList.Add(left.InnerList[0]);
                left.InnerList.RemoveAt(0);
            }
            else
            {
                InnerList.Add(right.InnerList[0]);
                right.InnerList.RemoveAt(0);
            }
        }

        while (left.Count() > 0)
        {
            InnerList.Add(left.InnerList[0]);
            left.InnerList.RemoveAt(0);
        }

        while (right.Count() > 0)
        {
            InnerList.Add(right.InnerList[0]);
            right.InnerList.RemoveAt(0);
        }
    }

    private void QuickSortHelper(int start, int end)
    {
        if (start < end)
        {
            int pivotIndex = Partition(start, end);
            QuickSortHelper(start, pivotIndex - 1);
            QuickSortHelper(pivotIndex + 1, end);
        }
    }

    private int Partition(int start, int end)
    {
        int pivot = (int)InnerList[end];
        int i = start - 1;

        for (int j = start; j < end; j++)
        {
            if ((int)InnerList[j] <= pivot)
            {
                i++;
                Swap(i, j);
            }
        }

        Swap(i + 1, end);
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        object temp = InnerList[i];
        InnerList[i] = InnerList[j];
        InnerList[j] = temp;
    }

    #endregion
}
