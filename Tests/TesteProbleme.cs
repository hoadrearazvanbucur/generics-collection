using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class TesteProbleme
    {
        private readonly ITestOutputHelper outputHelper;

        private ProblemeCoadaStack probleme;
        public TesteProbleme(ITestOutputHelper output)
        {
            this.outputHelper = output;
            probleme = new ProblemeCoadaStack();
        }

        [Fact]
        public void problema1()
        {
            Coada<int> c = new Coada<int>();
            c.push(1);
            c.push(2);
            c.push(3);
            probleme.downsize(c);
        }

        [Fact]
        public void problema2()
        {
            Coada<int> c = new Coada<int>();
            c.push(1);
            c.push(2);
            c.push(3);
            Assert.Equal(probleme.maxim(c), 1);
        }

        [Fact]
        public void problema3()
        {
            Stiva<int> o = probleme.oglindit(1234);
            outputHelper.WriteLine(o.afisare());
            Assert.Equal(o.peek().Data, 1);
        }

        [Fact]
        public void problema4()
        {
            Coada<int> c1 = new Coada<int>();
            c1.push(1);
            c1.push(2);
            c1.push(3);
            Coada<int> c2 = new Coada<int>();
            c2.push(4);
            c2.push(6);
            c2.push(7);
            Assert.True(probleme.alipire(c1, c2).isEmpty());
        }

        [Fact]

        public void problema5()
        {
            Coada<int> c = new Coada<int>();
            c.push(1);  c.push(2);  c.push(3);
            Assert.Equal(c.peek().Data, 1);
            outputHelper.WriteLine(probleme.sirMax(c).afisare());
        }

        [Fact]
        public void problema6()
        {
            Coada<int> c = new Coada<int>();
            c.push(1);  c.push(2);  c.push(3);
            outputHelper.WriteLine(probleme.reverse(c).afisare());
            Assert.Equal(probleme.reverse(c).size(),0);
        }

        [Fact]
        public void problema7()
        {
            outputHelper.WriteLine(probleme.inversareCuvinte("test*dsa*asbs").afisare());
            Stiva<string> s = probleme.inversareCuvinte("test*dsa*asbs");
            Assert.Equal(s.peek().Data, "dsa"); 
        }

        [Fact]
        public void problema8()
        {
            Coada<int> c = new Coada<int>();
            c.push(1); c.push(2); c.push(3);
            Coada<int> c1 = new Coada<int>();
            c1.push(5); c1.push(6); c1.push(8);
            outputHelper.WriteLine(probleme.interschimbare(c, c1).afisare());
            Assert.True(probleme.interschimbare(c, c1).isEmpty());
        }

        [Fact]
        public void problema9()
        {
            Coada<int> c = new Coada<int>();
            c.push(1); c.push(2); c.push(3);
            outputHelper.WriteLine(probleme.size(c).ToString());
            Assert.Equal(c.peek().Data, 1);
        }

        [Fact]
        public void problema10()
        {
            Coada<int> c = new Coada<int>();
            c.push(1); c.push(2); c.push(3);
            probleme.dimCor(c);
        }

        [Fact]
        public void problema11()
        {
            Stiva<int> c = new Stiva<int>();
            Stiva<int> c1 = new Stiva<int>();
            c.push(1); c.push(2); c.push(3);
            c1 = probleme.maximStiva(c);
            Assert.Equal(c1.peek().Data, 3);
            c.pop();
            Assert.Equal(c1.peek().Data, 3);
            outputHelper.WriteLine(c1.afisare());
        }

        [Fact]
        public void problema12()
        {
            Stiva<string> c = new Stiva<string>();
            Stiva<int> c1 = new Stiva<int>();
            c.push("1"); c.push("2"); c.push("3");
            outputHelper.WriteLine(probleme.cifreProp(c).afisare());
            Assert.True(probleme.cifreProp(c).isEmpty());
        }

        [Fact]
        public void problema13()
        {
            Coada<int> c = new Coada<int>();
            c.push(1); c.push(2); c.push(3);
            outputHelper.WriteLine(probleme.pushFals(c, 99).afisare());
            Assert.Equal(probleme.pushFals(c, 99).peek().Data, 1);
        }

        [Fact]
        public void problema14()
        {
            Coada<int> c = new Coada<int>();
            c.push(1); c.push(2); c.push(3);
            Assert.True(probleme.Palindrom("ana"));
            Assert.False(probleme.Palindrom("anaa"));
        }

        [Fact]
        public void problema15()
        {
            Coada<char> c = probleme.transCirc("ana");
            outputHelper.WriteLine(c.afisare());
            Assert.True(c.peek().Data.Equals('a'));
        }
    }
}
