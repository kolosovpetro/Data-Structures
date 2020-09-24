using DataStructures.LinkedList.Abstractions;

namespace DataStructures.LinkedList.Concrete
{
    public class DoubleLinkedList<T> : ILinkedList<T>
    {
        public bool IsEmpty { get; }
        public int Count { get; }
        public ILinkedListNode<T> First { get; }
        public ILinkedListNode<T> Last { get; }
        
        public ILinkedListNode<T> AddFirst(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFirst()
        {
            throw new System.NotImplementedException();
        }

        public ILinkedListNode<T> AddLast(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T entity)
        {
            throw new System.NotImplementedException();
        }

        public ILinkedListNode<T> Find(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Reverse()
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}