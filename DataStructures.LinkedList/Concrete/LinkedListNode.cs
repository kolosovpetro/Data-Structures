using DataStructures.LinkedList.Abstractions;

namespace DataStructures.LinkedList.Concrete
{
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        public T Value { get; }
        public ILinkedListNode<T> Next { get; set; }
        public ILinkedListNode<T> Previous { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}