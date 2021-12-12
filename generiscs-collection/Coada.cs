using System;
using System.Collections.Generic;
using System.Text;

namespace generiscs_collection
{
	public class Coada<T> where T : IComparable<T>
	{
        private Lista<T> lista;

        public Coada()
        {
            lista = new Lista<T>();
        }

        public void push(T data)
        {
            this.lista.adaugareStart(data);
        }
        public Node<T> pop()
        {
            Node<T> node= this.lista.obtine(this.lista.dimensiune() - 1);
            this.lista.stergere(this.lista.dimensiune() - 1);
            return node;
        }
        public Node<T> peek() => this.lista.obtine(this.lista.dimensiune()-1);
        public int size() => this.lista.dimensiune();
        public bool isEmpty() => this.lista.listaGoala();
        public string afisare()
        {
            string text = "";
            Node<T> save = this.lista.Head;
            while (save != null)
            {
                text += save.Data.ToString() + " ";
                save = save.Next;
            }
            return text;
        }
    }
}
