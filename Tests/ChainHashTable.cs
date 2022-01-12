using colectii_generice_implementare;
using generiscs_collection;
using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class ChainHashTable
    {
        private readonly ITestOutputHelper outputHelper;

        private ChainHashTable<string, Masina> lista;
        private CustomDictionary<string, Masina> nume;


        private SortedChainHashTable<String, Masina> sortare;


        public ChainHashTable(ITestOutputHelper output)
        {
            this.outputHelper = output;
            lista = new ChainHashTable<string, Masina>(4);
            nume = new CustomDictionary<string, Masina>(200);

            sortare = new SortedChainHashTable<String, Masina>(10);


        }

        [Fact]
        public void test()
        {
            lista.put("1", new Masina("a,1"));
            lista.put("11", new Masina("ba,1"));
            lista.put("111", new Masina("b,2"));
            lista.put("1111", new Masina("c,3"));
            this.outputHelper.WriteLine(lista.afisare()+"\n\n");
            this.outputHelper.WriteLine(lista.get("1")+"\n\n");
            lista.remove("1");
            this.outputHelper.WriteLine(lista.afisare() + "\n\n");

        }

        [Fact]
        public void test1()
        {
            nume.put("112", new Masina("Razvan,31"));
            nume.put("113", new Masina("Radu,15"));
            nume.put("114", new Masina("Raluca,11"));
            nume.put("115", new Masina("Ana,22"));
            nume.put("116", new Masina("Andreea,3"));
            nume.put("117", new Masina("Maria,33"));
            this.outputHelper.WriteLine(nume.afisare() + "\n\n");
        }

        [Fact]
        public void test2()
        {
            sortare.put("1", new Masina("Razvan,31"));
            sortare.put("11", new Masina("Raluca,11"));
            sortare.put("711", new Masina("Ana,22"));
            sortare.put("6111", new Masina("Andreea,3"));
            sortare.put("51111", new Masina("Maria,33"));
            sortare.put("111141", new Masina("Aaria,33"));
            sortare.put("3111111", new Masina("Zaria,33"));
            sortare.put("211111111", new Masina("Yaria,33"));
            sortare.put("32112111152", new Masina("Yaria,33"));
            sortare.put("5123123123123", new Masina("Saria,33"));

            //this.outputHelper.WriteLine(sortare.afisare() + "\n\n");


        }

    }
}
