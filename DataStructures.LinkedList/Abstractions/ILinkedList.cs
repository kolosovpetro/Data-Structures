namespace DataStructures.LinkedList.Abstractions
{
    public interface ILinkedList<T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        ILinkedListNode<T> First { get; }
        ILinkedListNode<T> Last { get; }
        ILinkedListNode<T> AddFirst(T entity);
        ILinkedListNode<T> AddLast(T entity);
        bool Contains(T entity);
        ILinkedListNode<T> Find(T entity);
    }
}