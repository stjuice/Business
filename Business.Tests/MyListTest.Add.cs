using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Tests
{
    public partial class MyListTest
    {
        [TestMethod]
        public void MyList_Add_CheckSingleElement()
        {
            var list = new MyList<int>();
            list.Add(1);
            var item = list.Get(0);

            Assert.AreEqual(1, list.Length);
            Assert.AreEqual(1, item);
        }

        [TestMethod]
        public void MyList_Add_CheckManyElements()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual( 1, list.Get(0));
            Assert.AreEqual( 2, list.Get(1));
            Assert.AreEqual( 3, list.Get(2));
        }
    }
}
