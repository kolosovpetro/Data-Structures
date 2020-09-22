using System;
using DataStructures.LinkedList.Abstractions;

namespace DataStructures.LinkedList.Concrete
{
    public class SingleLinkedList<T> : ILinkedList<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }
        public ILinkedListNode<T> First { get; private set; }
        public ILinkedListNode<T> Last => null;


        public ILinkedListNode<T> AddFirst(T entity)
        {
            var node = new LinkedListNode<T>(entity) {Next = First};
            First = node;
            Count++;
            return node;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Linked list is empty.");

            var first = First;
            First = First.Next;
            first.Next = null;
            Count--;
        }

        public ILinkedListNode<T> AddLast(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T entity)
        {
            var current = First;

            while (current != null)
            {
                if (current.Value.Equals(entity))
                    return true;
                if (current.Next == null)
                    break;
                current = current.Next;
            }

            return false;
        }

        public ILinkedListNode<T> Find(T entity)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}