using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Item<U>
    {
        public U CurrentItem { get; set; }
        public Item<U> NextItem { get; set; }
    }

}
