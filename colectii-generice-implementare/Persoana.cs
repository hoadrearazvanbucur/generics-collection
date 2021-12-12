using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_generice_implementare
{
    public class Persoana : IComparable<Persoana>
    {
        public string nume, prenume;

        public Persoana(string text)
        {
            string[] split = text.Split(",");
            this.nume = split[0];
            this.prenume = split[1];
        }

        public override string ToString() => this.nume + "," + this.prenume;
        public override bool Equals(object obj) => (obj as Persoana).nume == this.nume && (obj as Persoana).prenume == this.prenume;

        public bool ordineAlf(string a, string b)
        {
            int d;
            if (a.Length < b.Length)
                d = a.Length;
            else
                d = b.Length;
            for (int i = 0; i < d; i++)
                if (a[i] > b[i])
                    return false;
            if (a.Length > d)
                return false;
            return true;
        }
        public int CompareTo(Persoana other) => ordineAlf(other.Nume, this.nume) == true ? 1 : 0;

        public string Nume
        {
            get => this.nume;
            set => this.nume = value;
        }
        public string Prenume
        {
            get => this.prenume;
            set => this.prenume = value;
        }
    }
}
