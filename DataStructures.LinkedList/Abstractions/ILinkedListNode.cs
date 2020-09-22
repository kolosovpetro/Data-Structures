namespace DataStructures.LinkedList.Abstractions
{
    public interface ILinkedListNode<T>
    {
        T Value { get; }
        ILinkedListNode<T> Next { get; set; }
        ILinkedListNode<T> Previous { get; set; }
    }
}