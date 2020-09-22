using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Queue.Abstractions;

namespace DataStructures.Queue.Concrete
{
    public class QueueViaLinkedList<T> : IQueue<T>
    {
        private readonly LinkedList<T> _linkedList = new LinkedList<T>();
        private readonly int _capacity;

        public QueueViaLinkedList(int capacity)
        {
            _capacity = capacity;
        }

        public bool IsEmpty => _linkedList.First == null;
        public bool IsFull => Count >= _capacity;
        public int Count => _linkedList.Count;

        public void Enqueue(T entity)
        {
            if (IsFull)
                throw new IndexOutOfRangeException("Queue is full.");

            _linkedList.AddLast(entity);
        }

        public T Dequeue()
        {
            if (_linkedList.First == null)
                throw new IndexOutOfRangeException("Queue is empty.");

            var first = _linkedList.First.Value;
            _linkedList.RemoveFirst();
            return first;
        }

        public T Peek()
        {
            if (_linkedList.First == null)
                throw new IndexOutOfRangeException("Queue is empty.");

            return _linkedList.First.Value;
        }
    }
}