using System;

namespace Business
{

    public class MyStack<T>
    {
        class Item<U>
        {
            public U CurrentItem { get; set; }
            public Item<U> NextItem { get; set; }
        }

        Item<T> lastItem;

        public void Push(T item)
        {
            var tmp = lastItem;

            var newItem = new Item<T>();
            newItem.CurrentItem = item;

            lastItem = newItem;
            newItem.NextItem = tmp;
        }

        public T Pop()
        {
            if (lastItem == null)
                throw new InvalidOperationException();

            var tmp = lastItem;
            lastItem = lastItem.NextItem;

            return tmp.CurrentItem;
        }
    }

}
