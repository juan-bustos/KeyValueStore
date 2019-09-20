namespace KeyValueStore
{
    public struct KeyValue<TValue>
    {
        public readonly string key;

        public TValue value { get; }
        public KeyValue(string setKey, TValue setValue)
        {
            key = setKey;
            value = setValue;
        }
    }
}
