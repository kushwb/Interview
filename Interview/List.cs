using System;
using System.Collections.Generic;

namespace Interview
{
    public class GenericList<T> where T : new()
    {
        private List<T> _myList;
        public GenericList()
        {
            _myList = new List<T>();
        }
        public void Add(T value)
        {
            _myList.Add(value);
        }

        public T this[int index]
        {
            get { return _myList[index]; }
        }
    }
}