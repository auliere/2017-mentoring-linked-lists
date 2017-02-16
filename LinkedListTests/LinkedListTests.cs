using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Assert.AreEqual(0, linkedList.Length);
        }

        [TestMethod]
        public void LinkedListTest_FromList()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            Assert.AreEqual(5, linkedList.Length);
            Assert.IsTrue(linkedList.Contains(1));
            Assert.IsTrue(linkedList.Contains(2));
            Assert.IsTrue(linkedList.Contains(3));
            Assert.IsTrue(linkedList.Contains(4));
            Assert.IsTrue(linkedList.Contains(5));
        }

        [TestMethod]
        public void AddTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1);
            Assert.AreEqual(1, linkedList.Length);
            Assert.AreEqual(1, linkedList.ElementAt(0));
        }

        [TestMethod]
        public void AddAtTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ElementAtTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetEnumeratorTest()
        {
            Assert.Fail();
        }
    }
}