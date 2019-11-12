using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Business.Tests
{
    public partial class MyListTest
    {
        [TestMethod]
        public void MyList_Enumerator()
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
        public void MyList_Enumerator_CheckForeach()
        {
            var myList = new MyList<int>();
            myList.Add(34);
            myList.Add(87);
            myList.Add(100);
            myList.Add(87);
            myList.Add(20);

            var res = from i in myList
                      where (i % 10 == 0)
                      select i;

            foreach (var i in res)
                Console.WriteLine(i);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var e = new MyEndlessEnumerable();

            var res = e.Skip(3).Take(4).ToArray();

            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(4, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(6, res[3]);
        }
    }

    class MyEndlessEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var i = 0;
            while (true)
                yield return i++;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
