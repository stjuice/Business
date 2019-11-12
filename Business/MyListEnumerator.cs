using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MyListEnumerator<T> : IEnumerator<T>
    {
        Item<T> firstItem;
        Item<T> currentItem;

        public MyListEnumerator(Item<T> firstItem)
        {
            this.firstItem = firstItem;
        }

        object IEnumerator.Current => Current;

        T IEnumerator<T>.Current => Current;

        public void Dispose() { }

        public T Current => currentItem.CurrentItem;


        public bool MoveNext()
        {
            if (currentItem == null)
                currentItem = firstItem;
            else
                currentItem = currentItem.NextItem;
            
            return (currentItem != null);
        }

        public void Reset() => currentItem = null;
    }
}
