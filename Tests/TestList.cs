using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class TestList
    {
        private readonly ITestOutputHelper outputHelper;

        private ILista<Masina> masini;
        public TestList(ITestOutputHelper output)
        {
            this.outputHelper = output;
            masini = new Lista<Masina>();
        }

        [Fact]
        public void testAdaugareStergere()
        {
            masini.adaugare(new Masina("test1,1"));
            Assert.True(masini.exista(new Masina("test1,1")));
            masini.stergere(new Masina("test1,1"));
            Assert.False(masini.exista(new Masina("test1,1")));
            masini.adaugare(new Masina("test1,1"));
            masini.stergere(masini.pozitieData(new Masina("test1,1")));
            Assert.False(masini.exista(new Masina("test1,1")));
        }

        [Fact]
        public void testObtine()
        {
            masini.adaugare(new Masina("test1,1"));
            Assert.True(masini.obtine(0).Data.ToString()==new Masina("test1,1").ToString());
            masini.stergere(new Masina("test1,1"));
        }

        [Fact]
        public void testSeteaza()
        {
            masini.adaugare(new Masina("test2,2"));
            masini.seteaza(new Masina("test1,1"),1);
            Assert.True(masini.obtine(1).Data.ToString() == new Masina("test1,1").ToString());
            masini.stergere(0);
            masini.stergere(0);
        }

        [Fact]
        public void test()
        {
            //masini.adaugare(new Masina("test1,1"));
            //masini.adaugare(new Masina("test2,2"));
            //Assert.True(masini.dimensiune() == 2);
            //Assert.True(masini.pozitieData(new Masina("test1,1")) == 0);
            //Assert.True(masini.exista(new Masina("test1,1")));
            //Assert.False(masini.exista(new Masina("test1,2")));
            //Assert.False(masini.listaGoala());
            //masini.stergere(0);
            //masini.stergere(0);
            //Assert.True(masini.listaGoala());
        }

        [Fact]

        public void sort()
        {
            for(int i=5;i>=1;i--)
            this.masini.adaugare(new Masina($"test{i},{i}"));
            outputHelper.WriteLine(masini.afisare() + "\n\n");
            //this.masini.sort( new ComparatorMarcacs());
            for (int i=0;i<5;i++)
            Assert.True(masini.obtine(i).Data.ToString() == $"test{i+1},{i+1}");
            outputHelper.WriteLine(masini.afisare() + "\n\n");
            for(int i=0;i<5;i++)
                this.masini.stergere(0);
        }
    }
}
