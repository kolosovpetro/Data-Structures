namespace DataStructures.Vector.Abstractions
{
    public interface IVector<T>
    {
        /// <summary>
        /// Number of items
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// Number of items vector can hold
        /// </summary>
        int Capacity { get; }
        
        /// <summary>
        /// Checks whenever vector is empty
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Returns item at given index, blows up if index out of bounds
        /// </summary>
        T ElementAt(int index);

        /// <summary>
        /// Pushes new item to the vector
        /// </summary>
        void Push(T item);

        /// <summary>
        /// Inserts item at index, shifts that index's value and trailing elements to the right
        /// </summary>
        void Insert(int index, T value);

        /// <summary>
        /// Can use insert above at index 0
        /// </summary>
        void Prepend(T item);

        /// <summary>
        /// Remove from end, return value
        /// </summary>
        T Pop();

        /// <summary>
        /// Delete item at index, shifting all trailing elements left
        /// </summary>
        void DeleteAt(int index);

        /// <summary>
        /// looks for value and returns first index with that value, null if not found
        /// </summary>
        T FindItem(T item);
    }
}