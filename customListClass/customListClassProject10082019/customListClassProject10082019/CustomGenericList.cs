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
        private T[] primaryArray;
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
            primaryArray = new T[capacity];
        }

        //MEMBER METHODS
        public void Add(T item)
        {
            primaryArray[count] = item;
            count++;
            if(count == capacity)
            {
                T[] tempArray = new T[primaryArray.Length + 1];
                for (int i = 0; i < primaryArray.Length; i++)
                {
                    tempArray[i] = primaryArray[i];
                }
                tempArray[primaryArray.Length] = item;
                primaryArray = tempArray;
            }
           
        }

        public T this[int index]   
        {
            get
            {
                if(index >= 0 && index < count)
                {
                    return primaryArray[index];
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
                    primaryArray[index] = value;
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
            foreach (T item in primaryArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
