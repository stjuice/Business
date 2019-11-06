using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void MyStack_Pop()
        {
            var st = new MyStack<int>();
            st.Push(231);
            st.Push(76);
            st.Push(77);

            Assert.AreEqual(77, st.Pop());
            Assert.AreEqual(76, st.Pop());
        }
    
        [TestMethod]
        public void MyStack_Pop_LastItem()
        {
            var st = new MyStack<int>();
            st.Push(44);

            Assert.AreEqual(44, st.Pop());
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyStack_Pop_FromEmptyStack()
        {
            var st = new MyStack<int>();
            st.Pop();
        }

    }

}
