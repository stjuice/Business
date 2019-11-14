using System;
using Business;

namespace MyEnumeratorDisposeEvent
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
                listEnum.Notify += DisplayMessage;
                listEnum.MoveNext();
            }
        }

        private static void DisplayMessage(object sender, DisposedEventArgs e)
        {
            Console.WriteLine($"Disposed: {e.disposed}");
        }
    }
}
