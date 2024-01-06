using System.Collections;

namespace SequentialAccessCollections
{
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

            for(int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer -1; inner++)
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
    }
}
