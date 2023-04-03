
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MyList<T> : IEnumerable
    {
        private T[] _listArray;
        private int _count;
        private int Count { get; set; }
        public int Capacity { get; set; }

        public T this[int index]
        {
            get => _listArray[index];
            set
            {
                if (index > _listArray.Length)
                { 
                    throw new ArgumentOutOfRangeException("index");
                }
                _listArray[index] = value;
            }
        }
            
        public MyList()
        {
            _listArray = new T[0];
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            { 
                throw new AbandonedMutexException();
            }
            if (capacity > 0)
            { 
                _listArray = new T[capacity];
            }
            Capacity = capacity;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                if (_listArray[i] is null)
                {
                    break;
                }
                yield return _listArray[i];
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            { 
                int newCapacity = Capacity == 0 ? 4 : Capacity * 2;
                T[] _newListArray = new T[newCapacity];
                Array.Copy(_listArray, 0, _newListArray, 0, Capacity);
                _listArray  = _newListArray;
                Capacity = newCapacity;
            }

            _listArray[Count] = item;
            Count++;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_listArray[i].Equals(value))
                { 
                    return true;
                }
            }
            return false;
        }

        public bool Exsists(/*T value,*/Predicate<T> predicate)
        {
            foreach (T item in _listArray)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> predicate)
        {
            foreach (T item in _listArray)
            {
                if (predicate(item))
                { 
                    return item;
                }
            }
            return default;
        }

        public MyList<T> FindAll(Predicate<T> predicate)
        { 
            MyList<T> FoundElemsList = new MyList<T>();
            foreach (T item in _listArray)
            {
                if (predicate(item))
                { 
                    FoundElemsList.Add(item);
                }
            }
            return FoundElemsList;
        }

        public int FindIndex(Predicate<T> foundElement)
        {
            for (int i = 0; i < Count; i++)
            {
                if (foundElement(_listArray[Count]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse(int index, int destinCountRange)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (destinCountRange < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (Count > 1)
            {
                Array.Reverse(_listArray, index, destinCountRange);
            }
        }

        public bool Remove(int index, Predicate<T> predicate)
        {
            T[] removingArray = new T[Count - 1];
            for (int i = 0; i < Count; i++)
            {
                if (predicate(_listArray[index]) != predicate(_listArray[i]))
                { 
                    return false;
                }
                if (predicate(_listArray[i]))
                {
                    if (predicate(_listArray[index]) != predicate(_listArray[i]))
                    {
                        continue;
                    }
                    removingArray[i] = _listArray[i];
                }
            }
            _listArray = removingArray;
            return true;

        }
    }
}
