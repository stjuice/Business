using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Business.Tests
{
    public partial class MyListTest
    {        
        [TestMethod]
        public void MyList_OperatorOverload()
        {
            var list = new MyList<int>();
            list.Add(66);
            list.Add(12);
            list.Add(890);
            list.Add(54);
            list.Add(89);
            list.Add(44);

            Assert.AreEqual(890, list[2]);

        }
    }
}
