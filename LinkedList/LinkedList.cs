using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;

        public int Length { get; private set; }
        
        public LinkedList()
        {
            _head = null;
            Length = 0;
        }
        
        public LinkedList(params T[] list)
        {
            for (int i = list.Length - 1; i >= 0; i--)
                Add(list[i]);
        }

        public void Add(T element)
        {
            _head = new Node<T>(element, _head);
            Length++;
        }

        public void AddAt(T element, int index)
        {
            if (index == 0)
            {
                Add(element);
            }
            else
            {
                var node = NodeAt(index - 1);
                node.Next = new Node<T>(element, node.Next);
            }
        }

        public T Remove()
        {
            var node = _head;
            _head = _head.Next;
            Length--;
            return node.Value;
        }

        public T RemoveAt(int index)
        {
            if (index == 0)
                return Remove();
            var node = NodeAt(index - 1);
            var next = node.Next;
            var value = next.Value;
            node.Next = next.Next;
            Length--;
            return value;
        }

        public T ElementAt(int index)
        {
            return NodeAt(index).Value;
        }

        private Node<T> NodeAt(int index)
        {
            if (index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            Node<T> element = _head;
            int i = 0;
            while (i++ < index)
                element = element.Next;
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var element = _head;
            while (element != null)
            {
                yield return element.Value;
                element = element.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}
