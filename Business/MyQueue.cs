using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MyQueue<T>
    {
        class Item<U>
        {
            public U CurrentItem { get; set; }
            public Item<U> NextItem { get; set; }
        }

        Item<T> firstItem;

        public void Enqueue(T item)
        {
            if(firstItem == null)
            {
                firstItem = new Item<T> 
                { 
                    CurrentItem = item 
                };
                return;
            }

            var newItem = new Item<T> { CurrentItem = item };
            var tmp = firstItem;

            while (tmp.NextItem != null)
            {
                tmp = tmp.NextItem;
            }

            tmp.NextItem = newItem;

        }

        public T Peek()
        {
            if (firstItem == null)
                throw new InvalidOperationException();

            var res = firstItem.CurrentItem;

            firstItem = firstItem.NextItem;

            var tmp = firstItem;

            while(tmp!=null)
            {
                tmp = tmp.NextItem;
            }

            tmp = new Item<T> { CurrentItem = res };


            return res;

        }

        public void Clear()
        {
            firstItem = null;
        }
    }
}
