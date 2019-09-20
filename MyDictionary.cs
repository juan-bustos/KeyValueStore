using System.Collections.Generic;

namespace KeyValueStore
{
    public class MyDictionary<TValue>
    {
        KeyValue<TValue>[] keyValueArr = new KeyValue<TValue>[100];
        private int storedValues;

        public TValue this[string key]
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
                        keyValueArr[i] = new KeyValue<TValue>(key, value);
                        return;
                    }
                    if (keyValueArr[i].key == null)
                    {
                        keyValueArr[i] = new KeyValue<TValue>(key, value);
                        storedValues++;
                        return;
                    }
                }
            }             
        }
    }
}
