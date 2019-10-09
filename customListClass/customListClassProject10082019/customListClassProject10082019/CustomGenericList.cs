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
        private T[] items;

        //CONSTRUCTOR
        public CustomGenericList()
        {
            items = new T[4];
        }

        //MEMBER METHODS
        public void Add(T itemToAdd)
        {

        }

        public void Remove(T itemToRemove)
        {

        }
    }
}
