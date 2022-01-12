using generiscs_collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_generice_implementare
{
    public class ControlInchirieri
    {
        private Persoana persoana;
        private Lista<Inchirieri> inchirieri;
        private SimpleDictionar<Persoana, Lista<Inchirieri> > listaInchiriere;

        public ControlInchirieri(Persoana persoana, Lista<Inchirieri> inchirieri)
        {
            this.listaInchiriere = new SimpleDictionar<Persoana, Lista<Inchirieri>>();
            this.persoana = persoana;
            this.inchirieri = inchirieri;
        }

        public void inchiriaza(Masina masina)
        {
            inchirieri.adaugare(new Inchirieri(int.Parse(this.persoana.prenume), masina.Pret));
            listaInchiriere.put(this.persoana, this.inchirieri);
        }

        public void returneaza(Masina masina)
        {
            inchirieri.stergere(new Inchirieri(int.Parse(this.persoana.prenume),masina.Pret));
            //listaInchiriere.remove(persoana);
        }



    }
}
