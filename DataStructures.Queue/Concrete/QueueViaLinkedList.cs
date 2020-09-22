using DataStructures.Queue.Abstractions;

namespace DataStructures.Queue.Concrete
{
    public class QueueViaLinkedList<T> : IQueue<T>
    {
        public bool IsEmpty { get; }
        public bool IsFull { get; }
        public int Count { get; }
        public void Enqueue(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }
    }
}