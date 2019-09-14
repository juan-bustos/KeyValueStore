using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    class MyDictionary
    {
        KeyValue[] keyValueArr = new KeyValue[10];
        private int storedValues;

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < keyValueArr.Length; i++)
                {
                    if (keyValueArr[i].key == key)
                        return keyValueArr[i].value;
                }
                throw new KeyNotFoundException(key);
            }
            set
            {
                for (int i = 0; i < keyValueArr.Length; i++)
                {
                    if (keyValueArr[i].key == key)
                    {
                        keyValueArr[i] = new KeyValue(key, value);
                        return;
                    }
                    if (keyValueArr[i].key == null)
                    {
                        keyValueArr[i] = new KeyValue(key, value);
                        storedValues++;
                        return;
                    }
                }
            }             
        }
    }
}
