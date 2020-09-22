using System;
using DataStructures.Stack.Abstractions;

namespace DataStructures.Stack.Concrete
{
    public class StackViaArray<T> : IStack<T>
    {
        private readonly int _capacity;
        private readonly T[] _stackBase;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        private bool IsFull => Count >= _capacity;

        public StackViaArray(int capacity)
        {
            _capacity = capacity;
            _stackBase = new T[capacity];
        }

        public void Push(T entity)
        {
            if (IsFull) throw new IndexOutOfRangeException("Stack is full.");
            _stackBase[Count] = entity;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Stack is empty.");
            Count--;
            var top = _stackBase[Count];
            _stackBase[Count] = default;
            return top;
        }

        public T Peek() => _stackBase[Count - 1];
    }
}