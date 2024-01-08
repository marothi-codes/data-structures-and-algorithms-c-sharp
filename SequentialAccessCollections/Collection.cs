#nullable disable

using System.Collections;

namespace SequentialAccessCollections;

public class Collection : CollectionBase
{

    public void Add(object item)
    {
        InnerList.Add(item);
    }

    public void Remove(object item)
    {
        InnerList.Remove(item);
    }

    public new void Clear()
    {
        InnerList.Clear();
    }

    public new int Count()
    {
        return InnerList.Count;
    }

    public object Get(object item)
    {
        int index = InnerList.IndexOf(item);
        return InnerList[index];
    }

    #region Sorting Algorithms

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

    public void ShellSort()
    {
        int i, j, increment, temp;
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

    public void QuickSort()
    {
        QuickSortHelper(0, Count() - 1);
    }

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

    public bool SequentialSearch(int sValue)
    {
        for (int i = 0; i < InnerList.Count - 1; i++)
            if ((int)InnerList[i] == sValue)
                return true;
        return false;
    }

    public int BinarySearch (int value)
    {
        int end, start, mid;
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
