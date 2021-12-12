﻿using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_generice_implementare
{
    public class ComparatorNume : Comparer<Persoana>
    {
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

        public override int Compare(Persoana x, Persoana y) => ordineAlf(x.Nume, y.Nume) == true ? 1 : 0;
    }
}
