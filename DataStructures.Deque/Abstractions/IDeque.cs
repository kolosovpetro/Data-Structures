using System.Collections.Generic;

namespace DataStructures.Deque.Abstractions
{
    public interface IDeque<T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void EnqueueFirst(T data);
        void EnqueueLast(T data);
        bool Contains(T data);
        void Clear();
        LinkedListNode<T> DequeueFirst();
        LinkedListNode<T> DequeueLast();
        LinkedListNode<T> PeekFirst();
        LinkedListNode<T> PeekLast();
    }
}