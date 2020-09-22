using System;
using DataStructures.Queue.Abstractions;

namespace DataStructures.Queue.Concrete
{
    public class QueueViaArray<T> : IQueue<T>
    {
        private readonly T[] _array;
        private readonly int _capacity;

        public bool IsEmpty => Count == 0;
        public bool IsFull => Count >= _capacity;
        public int Count { get; private set; }

        public QueueViaArray(int capacity)
        {
            _capacity = capacity;
            _array = new T[capacity];
        }


        public void Enqueue(T entity)
        {
            if (IsFull)
                throw new IndexOutOfRangeException("Queue is full.");

            _array[Count] = entity;
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty.");

            var first = _array[0];

            for (var i = 0; i < Count - 1; i++) 
                _array[i] = _array[i + 1];

            Count--;
            return first;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty.");

            return _array[0];
        }
    }
}