using System.Collections.Generic;
using System.Linq;
using DataStructures.Deque.Abstractions;

namespace DataStructures.Deque.Implementations
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> _linkedList;

        public bool IsEmpty => _linkedList.Count == 0;
        public int Count => _linkedList.Count;

        public Deque()
        {
            _linkedList = new LinkedList<T>();
        }

        public void EnqueueFirst(T data)
        {
            var node = new LinkedListNode<T>(data);
            _linkedList.AddFirst(node);
        }

        public void EnqueueLast(T data)
        {
            var node = new LinkedListNode<T>(data);
            _linkedList.AddLast(node);
        }

        public bool Contains(T data)
        {
            return _linkedList.Any(x => x.Equals(data));
        }

        public void Clear()
        {
            _linkedList = new LinkedList<T>();
        }

        public LinkedListNode<T> DequeueFirst()
        {
            var first = _linkedList.First;
            _linkedList.RemoveFirst();
            return first;
        }

        public LinkedListNode<T> DequeueLast()
        {
            var last = _linkedList.Last;
            _linkedList.RemoveLast();
            return last;
        }

        public LinkedListNode<T> PeekFirst()
        {
            return _linkedList.First;
        }

        public LinkedListNode<T> PeekLast()
        {
            return _linkedList.Last;
        }
    }
}