using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customListClassProject10082019
{
    public class CustomGenericList<T>
    {
        //MEMBER VARIABLES
        private T[] underlyingArray;
        public T[] GenericArrayList;
        private int count;
        public int Count { get { return count; } }
        public int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }

        //CONSTRUCTOR
        public CustomGenericList()
        {
            count = 0;
            capacity = 4;
            underlyingArray = new T[capacity];
        }

        //MEMBER METHODS
        public void Add(T item)
        {
            underlyingArray[count] = item;
            count++;
            if(count == capacity)
            {
                T[] tempArray = new T[underlyingArray.Length + 1];
                for (int i = 0; i < underlyingArray.Length; i++)
                {
                    tempArray[i] = underlyingArray[i];
                }
                tempArray[underlyingArray.Length] = item;
                underlyingArray = tempArray;
            }
        }

        public T this[int index]   
        {
            get
            {
                if(index >= 0 && index < count)
                {
                    return underlyingArray[index];
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            set
            {
                if(index >=0 && index < count)
                {
                    underlyingArray[index] = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
        }

        public void Remove(T item)
        {

        }

        public void Print()
        {
            foreach (T item in underlyingArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
