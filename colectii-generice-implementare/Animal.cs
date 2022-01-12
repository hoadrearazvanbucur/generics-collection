using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_generice_implementare
{
    public class Animal : IComparable<Animal>
    {
        private string tip;
        private int an;

        public Animal(string text)
        {
            string[] textS = text.Split(",");
            this.tip = textS[0];
            this.an = int.Parse(textS[1]);
        }


        public override string ToString() => this.tip + "," + this.an;
        public override bool Equals(object obj) => (obj as Animal).tip == this.tip;


        public int CompareTo(Animal other)
        {
            if (this.an < other.an)
                return -1;
            else
                if (this.an == other.an)
                return 0;
            return 1;
        }


        public string Tip
        {
            get => this.tip;
            set => this.tip = value;
        }
        public int An
        {
            get => this.an;
            set => this.an = value;
        }
    }
}
