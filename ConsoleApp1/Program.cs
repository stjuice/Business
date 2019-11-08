using System;
using System.Collections.Generic;
using Business;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(34);
            myList.Add(87);
            myList.Add(100);
            myList.Add(87);
            myList.Add(20);


            var res = from i in myList
                      select i;

            foreach (var i in res)
                Console.WriteLine(i);
        }
    }
}
