﻿using System;

namespace Business
{
    public class Item<T>
    {
        public T CurrentItem { get; set; }
        public Item<T> NextItem { get; set; }
    }

    public class MyList<T>
    {
        Item<T> firstItem;
        public int Length { get; private set; }

        public void Add(T item)
        {
            if (Length == 0)
            {
                firstItem = new Item<T>
                {
                    CurrentItem = item
                };

                Length++;
                return;
            }

            var newItem = new Item<T>
            {
                CurrentItem = item
            };

            var tmp = firstItem;

            while (tmp.NextItem != null)
            {
                tmp = tmp.NextItem;
            }
            tmp.NextItem = newItem;

            Length++;

        }

        public T Get(int index)
        {
            if (firstItem == null)
            {
                throw new InvalidOperationException();
            }

            var tmp = firstItem;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.NextItem;
            }

            return tmp.CurrentItem;
        }

        public void RemoveAt(int index)
        {
            if (Length == 0 || index < 0 || index >= Length)
            {
                throw new InvalidOperationException();
            }

            if (index == 0)
            {
                firstItem = firstItem.NextItem;
                Length--;

                return;
            }

            var next = firstItem.NextItem;
            var prev = firstItem;

            for (int i = 0; i < index - 1; i++)
            {
                prev = prev.NextItem;
                next = next.NextItem;
            }
            
            prev.NextItem = next.NextItem;
            Length--;
        }
    }
}
