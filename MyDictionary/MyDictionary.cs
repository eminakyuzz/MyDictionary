using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] tempArray = keys;
            V[] tempArray2 = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempArray[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }
            values[values.Length - 1] = value;
        }
    }
}
