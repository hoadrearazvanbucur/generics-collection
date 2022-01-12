using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class HastTableTests
    {
        private readonly ITestOutputHelper outputHelper;

        private SimpleDictionar<string,string> testString;
        private SimpleDictionar<string,Masina> testMasina;
        private ControlInchirieri testInchiriaza;
        public HastTableTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            testString = new SimpleDictionar<string, string>();
            testMasina = new SimpleDictionar<string, Masina>();
        }

        [Fact]
        public void testStrings()
        {
            testString.put("1", "1");
            testString.put("11", "2");
            testString.put("111", "3");
            testString.put("111", "99");
            testString.put("1111", "4");
            testString.put("11111", "5");
            testString.put("111111", "6");
            testString.put("1111111", "7");
            testString.put("11111111", "8");
            //testString.put("111111111", "9");
            outputHelper.WriteLine(testString.afisare(9));
            outputHelper.WriteLine("\n\nPozitie: "+ testString.find("11111111111").ToString());
            outputHelper.WriteLine("\n\nValoare: "+ testString.get("111111").ToString());
            testString.remove("111");
            outputHelper.WriteLine("\n\nStergere:\n"+testString.afisare(9));

        }

        [Fact]
        public void testMasini()
        {
            testMasina.put("1", new Masina("test1,1"));
            testMasina.put("22", new Masina("test2,2"));
            testMasina.put("333", new Masina("test3,3"));
            testMasina.put("4444", new Masina("test4,4"));
            testMasina.put("55555", new Masina("test5,5"));
            testMasina.put("666666", new Masina("test6,6"));
            testMasina.put("7777777", new Masina("test7,7"));
            testMasina.put("88888888", new Masina("test8,8"));
            testMasina.put("999999999", new Masina("test9,9"));
            outputHelper.WriteLine(testMasina.afisare(9));
        }

        [Fact]
        public void testInchiriere()
        {
            Persoana p = new Persoana("Razvan,1");
            Lista<Inchirieri> lista = new Lista<Inchirieri>();
            this.testInchiriaza = new ControlInchirieri(p,lista);
            testInchiriaza.inchiriaza(new Masina("test,1"));
            testInchiriaza.inchiriaza(new Masina("test,2"));

            for (int i = 0; i < lista.dimensiune(); i++)
                outputHelper.WriteLine(lista.obtine(i).Data.IdMasina.ToString());

            testInchiriaza.returneaza(new Masina("test,2"));

            for (int i = 0; i < lista.dimensiune(); i++)
                outputHelper.WriteLine(lista.obtine(i).Data.IdMasina.ToString());
        }

        [Fact]
        public void sortare()
        {
            testMasina.put("1", new Masina("z,4"));
            testMasina.put("11", new Masina("b,1"));
            testMasina.put("111", new Masina("a,2"));
            testMasina.put("111", new Masina("e,3"));
            testMasina.put("1111", new Masina("g,5"));
            testMasina.put("11111", new Masina("h,6"));
            testMasina.put("111111", new Masina("j,7"));
            testMasina.put("1111111", new Masina("r,8"));
            testMasina.put("11111111", new Masina("i,9"));
            //testMasina.sortare(new ComparerAlfabetic());
            outputHelper.WriteLine(testMasina.afisare(9));

        }

        [Fact]

        public void comparator()
        {
            ComparerAlfabetic c = new ComparerAlfabetic();
            Masina m1 = new Masina("a,1");
            Masina m2 = new Masina("b,1");
            this.outputHelper.WriteLine(c.ordineAlf(m1.Marca, m2.Marca).ToString());
            Assert.True(c.Compare(m1, m2) == 1);
            Assert.True(c.Compare(m2, m1) == 0);
        }

    }
}
