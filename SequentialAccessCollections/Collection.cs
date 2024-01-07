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
        int i, j, inc, temp;
        inc = 3;

        while (inc > 0)
        {
            for (i = 0; i < InnerList.Count; i++)
            {
                j = i;
                temp = (int)InnerList[i];

                while ((j >= inc) && ((int)InnerList[j - inc] > temp))
                {
                    InnerList[j] = InnerList[j - inc];
                    j = j - inc;
                }

                InnerList[j] = temp;
            }

            if (inc / 2 != 0)
                inc = inc / 2;
            else if (inc == 1)
                inc = 0;
            else
                inc = 1;
        }
    }

}
