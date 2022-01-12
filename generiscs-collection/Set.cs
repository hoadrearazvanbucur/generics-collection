using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
    public class Set<T> where T : IComparable<T>
    {
        private Lista<T> lista;

        public Set()
        {
            this.lista = new Lista<T>();
        }

        public void adaugare(T data)
        {
            Node<T> it = lista.Head;
            if (lista.exista(data)==false)
                if (it == null)
                    this.lista.adaugare(data);
                else{
                    int k = 0;
                    while (it != null && it.Data.CompareTo(data) < 0){
                        k += 1;
                        it = it.Next;
                    }
                    this.lista.seteaza(data, k);
                }
        }
        public void adaugare(T data, Comparer<T> comparer)
        {
            Node<T> it = lista.Head;
            if (lista.exista(data) == false)
                if (it == null)
                    this.lista.adaugare(data);
                else{
                    int k = 0;
                    while (it != null && comparer.Compare(it.Data, data) == 1){
                        k += 1;
                        it = it.Next;
                    }
                    this.lista.seteaza(data, k);
                }
        }

        public void stergere(T data)
        {
            this.lista.stergere(this.lista.pozitieData(data)    );
        }        


        public bool exista(T data)
        {
            Node<T> node = lista.Head;
            while(node!=null)
            {
                if (data.Equals(node.Data)==true)
                    return true;
                node = node.Next;
            }
            return false;
        }
        public string afisare() => lista.afisare();
    }
}
