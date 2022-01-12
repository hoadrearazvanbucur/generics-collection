using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
    public class CustomDictionary<K,V>
    {
        private List<Stored<K, V>>[] hashtable;
        private int size;

        public CustomDictionary(int size)
        {
            this.size = size;
            this.hashtable = new List<Stored<K, V>>[size];
            for (int i = 0; i < size; i++)
            {
                hashtable[i] = new List<Stored<K, V>>();
            }
        }

        public int hashKey(V value)
        {
            return (int)value.ToString()[0];
        }

        public void put(K key, V value)
        {

            int poztie = hashKey(value);


            Stored<K, V> data = new Stored<K, V>();

            data.Key = key;
            data.Value = value;


            hashtable[poztie].Add(data);
        }



        public string afisare()
        {
            string text = "";
            for (int i = 0; i < this.size; i++)
            {
                if (this.hashtable[i].Count != 0)
                {
                    text += "Litera  "+(char) i+ ":  ";
                    for (int j = 0; j < this.hashtable[i].Count; j++)
                        text += this.hashtable[i][j].Value.ToString() + "  ,  ";
                    text += "\n";

                }
            }
            return text;
        }
    }
}
