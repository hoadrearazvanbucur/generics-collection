using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
    public class ChainHashTable<K,V>
    {
        private List<Stored<K, V>>[] hashtable;
        private int size;
   
        public ChainHashTable(int size)
        {
            this.size = size;
            this.hashtable = new List<Stored<K, V>>[size];
            for(int i = 0; i < size; i++)
            {
                hashtable[i] = new List<Stored<K, V>>();
            }
        }

        public int hashKey(K key)
        {
            return key.ToString().Length % hashtable.Length;
        }

        public void put(K key, V value)
        {

            int poztie = hashKey(key);


            Stored<K, V> data = new Stored<K, V>();

            data.Key = key;
            data.Value = value;


            hashtable[poztie].Add(data);
        }

        public V get(K key)
        {
            int p = this.hashKey(key);
            List<Stored<K,V>> list =this.hashtable[p];

            foreach(Stored<K,V> l in list)
            {
                if (l.Key.Equals(key) == true) 
                    return l.Value;
            }
            return default;
        }

        public string afisare()
        {
            string text = "";
            for (int i = 0; i < this.size; i++)
            {
                if (this.hashtable[i] != null)
                    for (int j = 0; j < this.hashtable[i].Count; j++)
                        text += this.hashtable[i][j].Value.ToString() + "  ,  ";
                text += "\n";
            }
            return text;
        }

        public void remove(K key)
        {
            int p = this.hashKey(key),k=0,s=0;
            List<Stored<K, V>> list = this.hashtable[p];

            foreach (Stored<K, V> l in list)
            {
                if (l.Key.Equals(key) == true)
                    s = k;
                k++;
            }
            list.RemoveAt(s);
        }

    }
}
