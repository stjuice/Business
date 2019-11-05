using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Tests
{
    public partial class MyListTest
    {
        [TestMethod]
        public void MyList_Remove_ExistingElement()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.RemoveAt(1);

            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(1, list.Get(0));
            Assert.AreEqual(3, list.Get(1));
        }

        [TestMethod]
        public void MyList_Remove_Last()
        {
            var list = new MyList<int>();
            list.Add(11);
            list.Add(22);
            list.Add(33);

            list.RemoveAt(2);

            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(11, list.Get(0));
            Assert.AreEqual(22, list.Get(1));
        }

        [TestMethod]
        public void MyList_Remove_First()
        {
            var list = new MyList<int>();
            list.Add(11);
            list.Add(22);
            list.Add(33);

            list.RemoveAt(0);

            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(22, list.Get(0));
            Assert.AreEqual(33, list.Get(1));
        }

        [TestMethod]
        public void MyList_Remove_One()
        {
            var list = new MyList<int>();
            list.Add(11);

            list.RemoveAt(0);

            Assert.AreEqual(0, list.Length);
        }

        [TestMethod]
        public void MyList_Remove_ExistingManyElements()
        {
            var list = new MyList<int>();
            list.Add(11);
            list.Add(22);
            list.Add(33);
            list.Add(44);
            list.Add(55);
            list.Add(66);

            list.RemoveAt(3);

            Assert.AreEqual(5, list.Length);
            Assert.AreEqual(11, list.Get(0));
            Assert.AreEqual(22, list.Get(1));
            Assert.AreEqual(33, list.Get(2));
            Assert.AreEqual(55, list.Get(3));
            Assert.AreEqual(66, list.Get(4));
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyList_Remove_FromEmpty()
        {
            var list = new MyList<int>();
            list.RemoveAt(1);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyList_Remove_FromEmptyNegativeIndex()
        {
            var list = new MyList<int>();
            list.RemoveAt(-1);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyList_Remove_NotExistingElement()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.RemoveAt(1);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyList_Remove_NotExistingElementNegativeIndex()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.RemoveAt(-1);
        }
    }
}
