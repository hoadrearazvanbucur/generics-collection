using System;
using System.Collections.Generic;







namespace generiscs_collection
{
    public class SortedChainHashTable<K,V> where V:IComparable<V>  
    {
        private SortedSet<SortedStored<K, V>>[] hashtable;
        private int size;

        public SortedChainHashTable(int size)
        {
            this.size = size;
            this.hashtable = new SortedSet<SortedStored<K, V>>[size];

            for (int i = 0; i < size; i++)
            {
                hashtable[i] = new SortedSet<SortedStored<K, V>>( );
            }
        }

        public int hashKey(K key)
        {
            return key.ToString().Length % hashtable.Length;
        }

        public void put(K key, V value)
        {
            int poztie = hashKey(key);

            SortedStored<K, V> data = new SortedStored<K, V>();


            data.Key = key;


            data.Value = value;


            this.hashtable[poztie].Add(data);


        
        }

        public string afisare()
        {
            string text = "";
            for (int i = 0; i < this.size; i++)
            {
                if (this.hashtable[i] != null)
                    foreach(var x in hashtable[i])
                        text += x.Value + "\n";           
                text += "\n";
            }
            return text;
        }

        public void remove(K key)
        {
            int p = this.hashKey(key), k = 0, s = 0;
            SortedSet<SortedStored<K, V>> list = this.hashtable[p];

            foreach (SortedStored<K, V> l in list)
            {
                if (l.Key.Equals(key) == true)
                    s = k;
                k++;
            }
            //list.RemoveAt(s);
        }

        public V get(K key)
        {
            int p = this.hashKey(key);
            SortedSet<SortedStored<K, V>> list = this.hashtable[p];
            foreach (SortedStored<K, V> l in list)
            {
                if (l.Key.Equals(key) == true)
                    return l.Value;
            }
            return default;
        }
    }
}
