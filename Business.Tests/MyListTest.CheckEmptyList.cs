using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Tests
{
    [TestClass]
    public partial class MyListTest
    {
        [TestMethod]
        public void MyList_CheckEmptyList_CheckLength()
        {
            var list = new MyList<int>();

            Assert.AreEqual(0, list.Length);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyList_CheckEmptyList()
        {
            var list = new MyList<int>();
            var listArray = list.Get(0);     
        }
    }
}
