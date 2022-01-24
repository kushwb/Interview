using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    public class Stack
    {
        private List<object> Items { get; set; }
        public Stack()
        {
            Items = new List<object>();
        }
        public void Push(object item)
        {
            if (item == null) throw new InvalidOperationException();
            Items.Add(item);
        }

        public object Pop()
        {
            var item = Items.Count > 0? Items[0]:null;
            Items.RemoveAt(Items.Count - 1);
            Console.WriteLine($"Items present in the list now is {Items.Count}");
            for(int i=0;i <Items.Count;i++)
                Console.WriteLine($"Items {i} : is {Items[i]}");
            return item;
        }

        public void Clear()
        {
            Items.Clear();
            Console.WriteLine($"Items present in the list now is {Items.Count}");
        }
    }
}