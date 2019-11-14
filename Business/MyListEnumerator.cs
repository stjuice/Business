using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MyListEnumerator<T> : IEnumerator<T>
    {
        public delegate void MyListEnumeratorHandler(object sender, DisposedEventArgs e);
        public event MyListEnumeratorHandler Notify;

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
            Notify?.Invoke(this, new DisposedEventArgs(disposed));
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                
                return;
            }
            disposed = true;
            Notify?.Invoke(this, new DisposedEventArgs(disposed));
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

    public class DisposedEventArgs
    {
        public bool disposed { get; }

        public DisposedEventArgs(bool disposed)
        {
            this.disposed = disposed;
        }
    }
}
