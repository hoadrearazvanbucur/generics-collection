using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class SetTests
    {
        private readonly ITestOutputHelper outputHelper;

        private Set<Masina> set;
        public SetTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            set = new Set<Masina>();
        }

        [Fact]
        public void testAdaugare1()
        {
            Masina m1 = new Masina("a,1");
            Masina m2 = new Masina("b,2");
            Masina m3 = new Masina("c,3");
            Masina m4 = new Masina("d,4");
            Masina m5 = new Masina("e,4");
            Masina m6 = new Masina("a,2");
            Masina m7 = new Masina("b,1");
            set.adaugare(m4);
            set.adaugare(m3);
            set.adaugare(m1);
            set.adaugare(m2);
            set.adaugare(m5);
            set.adaugare(m7);
            set.adaugare(m6);
            outputHelper.WriteLine("Afisarea 1 (PRET) \n" +set.afisare());

        }
        [Fact]
        public void testAdaugare2()
        {
            Masina m1 = new Masina("a,1");
            Masina m2 = new Masina("b,2");
            Masina m3 = new Masina("c,3");
            Masina m4 = new Masina("d,4");
            Masina m5 = new Masina("e,4");
            Masina m6 = new Masina("a,2");
            Masina m7 = new Masina("b,1");
            set.adaugare(m4, new ComparatorNume());
            set.adaugare(m3, new ComparatorNume());
            set.adaugare(m1, new ComparatorNume());
            set.adaugare(m2, new ComparatorNume());
            set.adaugare(m5, new ComparatorNume());
            set.adaugare(m7, new ComparatorNume());
            set.adaugare(m6, new ComparatorNume());
            outputHelper.WriteLine("Afisarea 2 (MARCA ALFABETIC)\n" + set.afisare());
        }
            
    }
}
