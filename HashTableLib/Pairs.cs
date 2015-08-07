using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableLib
{
    public class Pairs<T>
    {
        int key;
        T value ;

        public Pairs(T value)
        {
            this.value = value;
            this.key = value.GetHashCode();
        }

        public T GetValue()
        {
            return value;
        }

    }
}
