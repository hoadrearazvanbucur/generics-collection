using colectii_generice_implementare;
using generiscs_collection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class TestListPersoana
    {
        private readonly ITestOutputHelper outputHelper;

        private ILista<Persoana> masini;
        public TestListPersoana(ITestOutputHelper output)
        {
            this.outputHelper = output;
            masini = new Lista<Persoana>();
        }

        [Fact]

        public void sort()
        {
            //for (int i = 5; i >= 1; i--)
            //    this.masini.adaugare(new Persoana($"test{i},{i}"));
            //outputHelper.WriteLine(masini.afisare() + "\n\n");
            //this.masini.sort(new ComparatorNume());
            //for (int i = 0; i < 5; i++)
            //    Assert.True(masini.obtine(i).Data.ToString() == $"test{i + 1},{i + 1}");
            //outputHelper.WriteLine(masini.afisare() + "\n\n");
            //for (int i = 0; i < 5; i++)
            //    this.masini.stergere(0);
        }


    }
}
