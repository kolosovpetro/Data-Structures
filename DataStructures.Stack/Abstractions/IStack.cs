namespace DataStructures.Stack.Abstractions
{
    public interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Push(T entity);
        T Pop();
        T Peek();
    }
}