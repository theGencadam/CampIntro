using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<T,A>
    {
        T[] keys;
        A[] values;


        T[] temp_array1;
        A[] temp_array2;



        public Dictionary()
        {
            keys = new T[0];
            values = new A[0];

        }



        public void Add(T key, A value)
        {
            temp_array1 = keys;
            temp_array2 = values;



            keys = new T[keys.Length + 1];
            values = new A[values.Length + 1];

            for (int i = 0; i < temp_array1.Length; i++)
            {
                keys[i] = temp_array1[i];
            }

            values = new A[temp_array2.Length + 1];

            for (int i = 0; i < temp_array2.Length + 1; i++)
            {
                values[i] = temp_array2[i];
            }



            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int Count
        {
            get;

        }
    }
}
