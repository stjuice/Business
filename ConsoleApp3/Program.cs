using System;
using System.Collections.Generic;
using System.Reflection;
using Business;

namespace ConsoleApp3
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


            using (var listEnum = myList.GetEnumerator())
            {
                listEnum.MoveNext();
                Console.WriteLine(listEnum.Current.ToString());
            }



            Console.Read();
        }


    }
}


