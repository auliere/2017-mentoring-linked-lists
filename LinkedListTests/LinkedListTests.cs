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
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.AddAt(8, 2);
            Assert.AreEqual(2, linkedList.ElementAt(1));
            Assert.AreEqual(8, linkedList.ElementAt(2));
            Assert.AreEqual(3, linkedList.ElementAt(3));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddAtNegativeRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.AddAt(8, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddOutOfRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.AddAt(8, 6);
        }

        [TestMethod]
        public void RemoveTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.Remove();
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(2, linkedList.ElementAt(0));
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.RemoveAt(2);
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(4, linkedList.ElementAt(2));
            Assert.AreEqual(2, linkedList.ElementAt(1));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RemoveAtNegariveRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.RemoveAt(-1);
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(4, linkedList.ElementAt(2));
            Assert.AreEqual(2, linkedList.ElementAt(1));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RemoveAtOutOfRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.RemoveAt(6);
        }

        [TestMethod]
        public void ElementAtTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            Assert.AreEqual(1, linkedList.ElementAt(0));
            Assert.AreEqual(3, linkedList.ElementAt(2));
            Assert.AreEqual(5, linkedList.ElementAt(4));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ElementAtNegativeRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.ElementAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ElementAtOutOfRangeTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            linkedList.ElementAt(6);
        }

        [TestMethod]
        public void ForeachTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1, 2, 3, 4, 5);
            string s = "";
            foreach (var i in linkedList)
            {
                s += i;
            }
            Assert.AreEqual("12345", s);
        }
    }
}