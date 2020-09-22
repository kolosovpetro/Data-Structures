using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.QueueViaArray.Interfaces;

namespace DataStructures.QueueViaArray.Implementations
{
    public class Queue<T> : IQueue<T>
    {
        private readonly List<T> _queueBase;
        public int Count => _queueBase.Count;
        public int Capacity { get; }

        public Queue(int capacity)
        {
            Capacity = capacity;
            _queueBase = new List<T>(capacity);
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
            return _queueBase.First();
        }

        public bool IsEmpty() => Count == 0;
        public bool IsFull() => Count >= Capacity;
        public void Clear() => _queueBase.Clear();
        public bool Contains(T data) => _queueBase.Contains(data);

        public void CopyTo(ref T[] array, int startIndex)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            array = _queueBase.Skip(startIndex).ToArray();
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");

            var first = _queueBase.First();
            _queueBase.Remove(first);
            return first;
        }

        public void Enqueue(T data)
        {
            if (IsFull()) throw new InvalidOperationException("Queue is full");
            _queueBase.Add(data);
        }

        public T[] ToArray() => _queueBase.ToArray();
    }
}