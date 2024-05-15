using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linkedLists
{
    internal class LinkedList
    {
        private Node _head { get; set; }
        private Node _tail { get; set; }
        private Node _maxNode { get; set; }
        private Node _minNode { get; set; }
        private int _size;

        public LinkedList(Node head)
        {
            _head = head;
            _tail = head;
            _maxNode = head;
            _minNode = head;
            _size = 1;
        }

        public void Append(int item)
        {
            _tail.Next = new Node(item);
            _tail = _tail.Next;
            InputCheck(item);
        }

        public void Prepend(int item)
        {
            Node newNode = new Node(item);
            newNode.Next = _head;
            _head = newNode;
            InputCheck(item);
        }

        private void InputCheck(int item)
        {
            if (_maxNode.Value < item)
            {
                _maxNode = new Node(item);
            }
            else if (_minNode.Value > item)
            {
                _minNode = new Node(item);
            }
            _size++;
        }

        public int Pop()
        {
            Node headSaver = _head;
            Node tailSaver = _tail;
            while (headSaver.Next.Next != null)
            {
                headSaver = headSaver.Next;
            }
            headSaver.Next = null;
            _tail = headSaver;
            _size--;
            return tailSaver.Value;
        }

        public int Unqueue()
        {
            Node headSaver = _head;
            _head = _head.Next;
            return headSaver.Value;
        }

        public IEnumerable<int> ToList()
        {
            IEnumerable<int> list = new List<int>();
            Node headSaver = _head;

            while (headSaver != null)
            {
                list.Append(headSaver.Value);
                headSaver = headSaver.Next;
            }
            return list;
        }

        public bool IsCircular()
        {
            return _tail == _head;
        }

        public void Sort()
        {
            Node headSaver = _head;
            int[] itemArr = new int[_size];
            int index = 0;
            while (headSaver != null)
            {
                itemArr[index] = headSaver.Value;
                headSaver = headSaver.Next;
                index++;
            }
            Array.Sort(itemArr); 
            
            _head = new Node(itemArr[0]);
            headSaver = _head;
            for (int i = 1; i < itemArr.Length; i++)
            {
                headSaver.Next = new Node( itemArr[i]);
                headSaver = headSaver.Next;
            }
        }
        public Node GetMaxNode()
        {
            return _maxNode;
        }

        public Node GetMinNode()
        {
            return _minNode;
        }

        public void Print()
        {
            Node headSaver = _head;
            while (headSaver != null)
            {
                Console.Write(headSaver.Value.ToString() + " -> ");
                headSaver = headSaver.Next;
            }
            Console.WriteLine( );
        }
    }
}
