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
        bool disposed = false;

        public MyListEnumerator(Item<T> firstItem)
        {
            this.firstItem = firstItem;
        }

        object IEnumerator.Current => Current;

        T IEnumerator<T>.Current => Current;

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            disposed = true;
        }

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
