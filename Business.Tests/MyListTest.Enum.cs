using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Business.Tests
{
    public partial class MyListTest
    {
        [TestMethod]
        public void MyList_Enum()
        {

            var myList = new MyList<int>();
            myList.Add(34);
            myList.Add(87);
            myList.Add(100);
            myList.Add(87);
            myList.Add(20);

            var listEnum = myList.GetEnumerator();
   
            listEnum.MoveNext();
            Assert.AreEqual(34, listEnum.Current); 
            
            listEnum.MoveNext();
            Assert.AreEqual(87, listEnum.Current);
        }

        [TestMethod]
        public void MyList_Enum_2()
        {
            var myList = new MyList<int>();
            myList.Add(34);
            myList.Add(87);
            myList.Add(100);
            myList.Add(87);
            myList.Add(20);

            var listEnum = myList.GetEnumerator();

            var res = from i in myList
                      where (i % 10 == 0)
                      select i;

            foreach(var i in res)
                Console.WriteLine(i);

        }
    }
}
