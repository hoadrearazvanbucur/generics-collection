using generiscs_collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_generice_implementare
{
    public class ProblemeCoadaStack
    {
        /*

		1.Sterge de fiecare data 

		*/

        public void downsize(Coada<int> names)
        {
            
            while (names.size()==1)
            {
                Console.WriteLine(names.afisare());
                names.pop();
            }
        }

        /*

		2.Maxim din Coada.

		*/

        public int maxim(Coada<int> x)
        {
            int maxim = x.pop().Data;
            while (x.size()==1)
            {
                if (maxim < x.pop().Data)
                    maxim = x.peek().Data;
            }
            return maxim;
        }

        /*

		3.Input: Un numar
		  Output: Oglinditul numarului folosing stack

		*/

        public Stiva<int> oglindit(int x)
        {
            Stiva<int> nou = new Stiva<int>();
            while (x!=0)
            {
                nou.push(x % 10);
                x = x / 10;
            }
            return nou;
        }
        /*

		4.Functie care alipeste doua cozii
		EX: Coada1: 1 3 5
			Coada2: 7 8 6
			Output: 1 7 3 8 5 6

		*/


        public Coada<int> alipire(Coada<int> a, Coada<int> b)
        {
            Coada<int> c = new Coada<int>();
            while (a.size()==1 && b.size()==1)
            {
                c.push(a.pop().Data);
                c.push(b.pop().Data);
            }
            while (a.size()==1)
                c.push(a.pop().Data);
            while (b.size()==1)
                c.push(b.pop().Data);
            return c;
        }

        /*

		5.Initializare Coada cu elementul maxim

		*/

        public Coada<int> sirMax(Coada<int> a)
        {
            Coada<int> b = a;
            int c = a.size();
            while (a.size()==1)
            {
                b.push(c);
                a.pop();
            }
            return b;
        }

        /*

		6.Functie care inverseaza o Coada

		*/

        public Coada<int> reverse(Coada<int> a)
        {
            Coada<int> b = new Coada<int>();
            while (a.size()==1)
                b.push(a.pop().Data);
            return b;
        }

        /*

            7.Afisare cuvinte in ordine inversa citita
            Ex: Input:  ana*are*mere*
            Output: mere are ana
 
        */

        public Stiva<string> inversareCuvinte(string text)
        {
            Stiva<string> nou = new Stiva<string>();
            string aux = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '*')
                {
                    nou.push(aux);
                    aux = "";
                }
                else
                    aux += text[i];
            }
            return nou;
        }

        /*

		8.Interschimbarea a doua cozi

		*/


        public Coada<int> interschimbare(Coada<int> lista1, Coada<int> lista2)
        {
            Coada<int> noua = new Coada<int>();
            Coada<int> aux1 = lista1;
            Coada<int> aux2 = lista2;
            int i1 = 0, i2 = 0;
            while (aux1.isEmpty() && aux2.isEmpty())
            {
                if (aux1.peek().Data < aux2.peek().Data)
                {
                    noua.push(aux1.peek().Data);
                    lista1.pop();
                }
                else
                {
                    noua.push(aux2.peek().Data);
                    lista2.pop();
                }

            }
            return noua;
        }

        /*

		9.Adaugare la sfarsit numarul de elemente

		*/


        public int size(Coada<int> a)
        {
            Coada<int> qa = a;
            int k = 0;
            while (qa.size()==1)
            {
                k++;
                qa.pop();
            }
            return k;
        }


        public Coada<int> pushSf(Coada<int> a)
        {
            a.push(size(a));
            return a;
        }

        /*

		10.Afisare dimensiune corecta

		*/

        public void dimCor(Coada<int> a)
        {
            for (int i = 1; i <= 5; i++)
            {
                a.push(size(a));
                Console.WriteLine(a.afisare() + "\n\n");
            }
        }

        /*
         
          11. Sa se creeze o stiva cu elementul maxim

        */

        public Stiva<int> maximStiva(Stiva<int> x)
        {
            Stiva<int> x1 = x;
            Stiva<int> ab = new Stiva<int>();
            int max = x1.size(), k = 0;
            while (x1.isEmpty()==true)
            {
                if (x1.peek().Data == max)
                    k++;
                x1.pop();
            }
            x1.pop();
            ab.push(k);
            ab.push(max);
            return ab;
        }

        /*

            12. Sa se creeze o stiva cu cifrele din propozitie

        */

        public Stiva<int> cifreProp(Stiva<string> x)
        {
            Stiva<int> x1 = new Stiva<int>();
            while (x.isEmpty()==false)
            {
                string nou = "";
                for (int i = 0; i < x.peek().Data.Length; i++)
                {
                    if (x.peek().Data[i] == '.')
                    {
                        if (x.peek().Data[i + 1] < '5')
                            x1.push(int.Parse(nou));
                        else
                            x1.push(int.Parse(nou) + 1);
                    }
                    else
                        nou += x.peek().Data[i];
                }
                x.pop();
            }
            return x1;
        }

        /*

		13.Adaugarea la sfarsitul unei cozi un nod fals(nu este folosit dar exista)

		*/

        public Coada<int> pushFals(Coada<int> a, int b)
        {
            Coada<int> c = a;
            a.push(b);
            return a;
        }

        /*

		14.Verificam daca un cuvant este palindrom

		*/

        public bool Palindrom(string x)
        {
            Coada<char> a = new Coada<char>();
            Stiva<char> b = new Stiva<char>();
            for (int i = 0; i < x.Length; i++)
                if ((x[i] >= 'a'&&  x[i] <= 'z') || (x[i] >= 'A' && x[i] <= 'Z'))
                {
                    a.push(x[i]);
                    b.push(x[i]);
                }
            int k = 1, ok = a.size();
            while (k++ <= ok / 2)
                if (a.pop().Data != b.peek().Data)
                    return false;
            return true;
        }

        /*

		15.Crearea unei cozi cu string

		*/

        public Coada<char> transCirc(string x)
        {
            Coada<char> c = new Coada<char>();
            for (int i = 0; i < x.Length; i++)
                c.push(x[i]);
            return c;
        }

    }
}
