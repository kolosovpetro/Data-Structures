using System;
using System.Collections.Generic;
using System.Linq;
using StackLibrary.Interfaces;

namespace DataStructures.StackViaArray.Implementation
{
    public class Stack<T> : IStack<T>
    {
        public int Capacity { get; }
        public int Count => _stackBase.Count;
        private readonly List<T> _stackBase;

        public Stack(int capacity)
        {
            Capacity = capacity;
            _stackBase = new List<T>(capacity);
        }

        public T Peek()
        {
            if (!IsEmpty())
                return _stackBase.Last();

            throw new InvalidOperationException("Stack is empty");
        }

        public bool IsEmpty() => Count == 0;
        public bool IsFull() => Count >= Capacity;
        public void Clear() => _stackBase.Clear();
        public bool Contains(T data) => _stackBase.Contains(data);

        public void CopyTo(ref T[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            array = _stackBase.Skip(index).ToArray();
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("Stack is empty");

            var top = _stackBase.Last();
            _stackBase.RemoveAt(_stackBase.Count - 1);
            return top;
        }

        public void Push(T data)
        {
            if (!IsFull()) _stackBase.Add(data);
        }

        public T[] ToArray() => _stackBase.ToArray();
    }
}