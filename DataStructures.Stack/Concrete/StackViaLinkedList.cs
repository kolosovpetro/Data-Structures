using DataStructures.Stack.Abstractions;

namespace DataStructures.Stack.Concrete
{
    public class StackViaLinkedList<T> : IStack<T>
    {
        public int Count { get; }
        public bool IsEmpty { get; }
        public void Push(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Pop()
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }
    }
}