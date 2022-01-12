using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_generice_implementare
{
    public class Inchirieri : IComparable<Inchirieri>
    {

        private int id;
        private int idMasina, idPersoana;

        public Inchirieri(int idPersoana,int idMasina)
        {
            this.idPersoana = idPersoana;
            this.idMasina = idMasina;
        }

        public int IdMasina
        {
            get => this.idMasina;
            set => this.idMasina = value;
        }
        public int IdPersoana
        {
            get => this.idPersoana;
            set => this.idPersoana = value;
        }

        public int CompareTo([AllowNull] Inchirieri other)
        {
            throw new NotImplementedException();
        }
    }
}
