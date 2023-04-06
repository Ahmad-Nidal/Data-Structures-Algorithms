using HTU.DSAlgo.DataStructures;
using NUnit.Framework;
using System.Collections.Generic;

namespace MyLinkedListTests
{
    public class Tests
    {
        [Test]
        public void Add_IncreasesCount()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.That(list.Count, Is.EqualTo(3));
        }

        [Test]
        public void Add_AddsToTail()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.That(list.ToString(), Is.EqualTo("1, 2, 3"));
        }

        [Test]
        public void Clear_ResetsList()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            Assert.That(list.Count, Is.EqualTo(0));
            Assert.IsTrue(list.IsEmpty);
        }

        [Test]
        public void IndexOf_ReturnsCorrectIndex()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.That(list.IndexOf(2), Is.EqualTo(1));
        }

        [Test]
        public void Insert_InsertsAtCorrectIndex()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(1, 4);
            Assert.That(list.ToString(), Is.EqualTo("1, 4, 2, 3"));
        }

        [Test]
        public void RemoveAt_RemovesFromCorrectIndex()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            Assert.That(list.ToString(), Is.EqualTo("1, 3"));
        }

        [Test]
        public void Contains_ReturnsTrueForContainedValue()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsTrue(list.Contains(2));
        }

        [Test]
        public void Remove_RemovesCorrectValue()
        {
            var list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
            Assert.That(list.ToString(), Is.EqualTo("1, 3"));
        }
    }
}
