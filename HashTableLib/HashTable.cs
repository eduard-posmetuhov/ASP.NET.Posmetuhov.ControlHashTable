using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableLib
{
    public class HashTable<T>
    {
        List<Pairs<T>> storage;

        public HashTable()
        {
            storage = new List<Pairs<T>>();
        }

        public HashTable(params T[]arrayValue)
        {
            storage = new List<Pairs<T>>();
            foreach (var item in arrayValue)
                Add(item);
        }

        public void Add(T value)
        {
            if (!this.ContainsValue(value))
            storage.Add(new Pairs<T>(value));            
        }

        public bool ContainsKey(int key)
        {
            foreach (var item in storage)
            {
                if (item.GetValue().GetHashCode() == key)
                    return true;
            }
            return false;
        }

        public bool ContainsValue(T value)
        {
            foreach (var item in storage)
            {
                if (item.GetValue().Equals(value))
                    return true;
            }
            return false;
        }



    }
}
