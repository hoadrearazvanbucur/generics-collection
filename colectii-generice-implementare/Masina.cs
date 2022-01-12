using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_generice_implementare
{
    public class Masina : IComparable<Masina>
    {
        private string marca;
        private int pret;

        public Masina(string text)
        {
            string[] split = text.Split(",");
            this.marca = split[0];
            this.pret = int.Parse(split[1]);
        }

        public override string ToString() => this.marca + "," + this.pret;
        public override bool Equals(object obj) => (obj as Masina).marca.Equals(this.marca) && (obj as Masina).pret == this.pret;

        public int CompareTo(Masina other)
        {
            if (this.pret > other.pret)
                return 1;

            else if (this.pret < other.pret)
            {
                return -1;
            }

            return 0;
        }

        public string Marca
        {
            get => this.marca;
            set => this.marca = value;
        }
        public int Pret
        {
            get => this.pret;
            set => this.pret = value;
        }
    }
}
