using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MyListEnum<T> : IEnumerator<T>
    {

        Item<T> firstItem;
        Item<T> currentItem;

        public MyListEnum(Item<T> firstItem)
        {
            this.firstItem = firstItem;
        }

        object IEnumerator.Current => throw new NotImplementedException();

        T IEnumerator<T>.Current => Current;

        public void Dispose()
        {

        }

        public T Current
        {
            get
            {
                try
                {
                    return currentItem.CurrentItem;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            if (currentItem == null)
                currentItem = firstItem;
            else
                currentItem = currentItem.NextItem;
            
            return (currentItem != null);
        }

        public void Reset()
        {
            currentItem = null;
        }
    }
}
