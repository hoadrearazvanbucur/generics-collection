using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
    public class Stiva<T> where T:IComparable<T>
    {
        private Lista<T> lista;

        public Stiva()
        {
            lista = new Lista<T>();
        }

        public  void push(T data)
        {
            this.lista.adaugareStart(data);
        }
        public void pop()
        {
            this.lista.stergere(0);
        }
        public Node<T> peek() => this.lista.obtine(0);
        public int size() => this.lista.dimensiune();
        public bool isEmpty() => this.lista.listaGoala();
        public string afisare()
        {
            string text = "";
            Node<T> save = this.lista.Head;
            while(save!=null)
            {
                text += save.Data.ToString()+"\n";
                save = save.Next;
            }
            return text;
        }

        
    }
}
