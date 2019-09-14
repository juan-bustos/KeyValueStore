using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public struct KeyValue
    {
        public readonly string key;
        public readonly object value;
        public KeyValue(string setKey, object setValue)
        {
            key = setKey;
            value = setValue;
        }
    }
}
