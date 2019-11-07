using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void MyQueue_Enqueue_OneItem()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(231);

            Assert.AreEqual(231, queue.Peek());
        }

        [TestMethod]
        public void MyQueue_Enqueue_ManyItem()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(45);
            queue.Enqueue(89);
            queue.Enqueue(34);
            queue.Enqueue(8459);

            Assert.AreEqual(45, queue.Peek());
        }

        [TestMethod]
        public void MyQueue_Peek_TwoItems()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(45);
            queue.Enqueue(89);

            Assert.AreEqual(45, queue.Peek());
            Assert.AreEqual(89, queue.Peek());
        }

        [TestMethod]
        public void MyQueue_Peek_ManyItems()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(45);
            queue.Enqueue(89);
            queue.Enqueue(32);
            queue.Enqueue(99);

            Assert.AreEqual(45, queue.Peek());
            Assert.AreEqual(89, queue.Peek());
            Assert.AreEqual(32, queue.Peek());
            Assert.AreEqual(99, queue.Peek());
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyQueue_Peek_FromEmptyStack()
        {
            var queue = new MyQueue<int>();
            queue.Peek();
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MyQueue_Clear()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(45);
            queue.Enqueue(89);
            queue.Enqueue(32);
            queue.Enqueue(99);

            queue.Clear();
            
            queue.Peek();
        }

    }

}
