using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
    public class Stored<K,V>
    {
        private K key;
        private V value;


        public K Key
        {
            get => this.key;
            set => this.key = value;
        }
        public V Value
        {
            get => this.value;
            set => this.value = value;
        }

        public int CompareTo(V other)
        {
            throw new NotImplementedException();
        }
    }
}
