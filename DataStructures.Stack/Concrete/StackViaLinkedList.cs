using System;
using System.Collections.Generic;
using DataStructures.Stack.Abstractions;

namespace DataStructures.Stack.Concrete
{
    public class StackViaLinkedList<T> : IStack<T>
    {
        private readonly LinkedList<T> _linkedList = new LinkedList<T>();
        public int Count => _linkedList.Count;
        public bool IsEmpty => _linkedList.Last == null;

        public void Push(T entity) => _linkedList.AddLast(entity);

        public T Pop()
        {
            if (_linkedList.Last == null)
                throw new IndexOutOfRangeException("Stack is empty.");

            var last = _linkedList.Last;
            _linkedList.RemoveLast();
            return last.Value;
        }

        public T Peek()
        {
            if (_linkedList.Last == null)
                throw new IndexOutOfRangeException("Stack is empty.");
            return _linkedList.Last.Value;
        }
    }
}