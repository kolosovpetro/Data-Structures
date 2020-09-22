namespace DataStructures.Queue.Abstractions
{
    public interface IQueue<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        int Count { get; }
        void Enqueue(T entity);
        T Dequeue();
        T Peek();
    }
}