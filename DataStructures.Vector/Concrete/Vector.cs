using System;
using DataStructures.Vector.Abstractions;

namespace DataStructures.Vector.Concrete
{
    public class Vector<T> : IVector<T>
    {
        private T[] _vectorArray;

        public int Count { get; private set; }
        public int Capacity => _vectorArray.Length;
        public bool IsEmpty => Count == 0;

        public Vector() => _vectorArray = new T[2];

        public T ElementAt(int index)
        {
            if (index < 0 || index > Capacity)
                throw new IndexOutOfRangeException("Index out of vector's range");

            return _vectorArray[index];
        }

        public void Push(T item)
        {
            if (Count == Capacity)
                _vectorArray = ResizeArray(2 * Capacity);

            _vectorArray[Count] = item;
            Count++;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > Capacity)
                throw new IndexOutOfRangeException("Index cannot exceed capacity");

            if (index == Count)
            {
                Push(value);
                return;
            }

            Count++;

            if (Count == Capacity)
            {
                _vectorArray = ResizeArray(2 * Capacity);
            }

            for (var i = Count - 1; i >= index; i--)
            {
                _vectorArray[i + 1] = _vectorArray[i];
                _vectorArray[i] = default;
            }

            _vectorArray[index] = value;
        }

        public void Prepend(T item) => Insert(0, item);

        public T Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Vector is empty");

            var element = _vectorArray[Count - 1];
            Count--;

            if (Count == Capacity / 2)
            {
                _vectorArray = ResizeArray(Capacity / 2);
                return element;
            }

            _vectorArray[Count] = default;
            return element;
        }


        public void DeleteAt(int index)
        {
            if (index < 0 || index > Capacity)
                throw new IndexOutOfRangeException("No such index in array");

            _vectorArray[index] = default;

            for (var i = index; i < Count; i++)
            {
                var temp = _vectorArray[i];
                _vectorArray[i] = _vectorArray[i + 1];
                _vectorArray[i + 1] = temp;
            }

            Count--;

            if (Count == Capacity / 2)
            {
                _vectorArray = ResizeArray(Capacity / 2);
            }
        }

        public T FindItem(T item)
        {
            for (var i = 0; i < Count; i++)
            {
                if (_vectorArray[i].Equals(item))
                    return _vectorArray[i];
            }

            return default;
        }

        private T[] ResizeArray(int newCapacity)
        {
            var newArray = new T[newCapacity];
            Array.Copy(_vectorArray, 0, newArray, 0, Count);
            return newArray;
        }
    }
}