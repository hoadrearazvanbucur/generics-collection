using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class StackTests
    {
        private readonly ITestOutputHelper outputHelper;

        private Stiva<Masina> masini;
        public StackTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            masini = new Stiva<Masina>();
        }

        [Fact]

        public void tests()
        {
            masini.push(new Masina("test1,1"));
            Assert.Equal(masini.peek().Data.ToString(), "test1,1");
            masini.push(new Masina("test2,2"));
            Assert.Equal(masini.peek().Data.ToString(), "test2,2");
            masini.push(new Masina("test3,3"));
            Assert.Equal(masini.peek().Data.ToString(), "test3,3");
            masini.pop();
            Assert.False(masini.isEmpty());
            Assert.Equal(masini.peek().Data.ToString(), "test2,2");
            masini.pop();
            Assert.Equal(masini.peek().Data.ToString(), "test1,1");
            masini.pop();
            Assert.True(masini.isEmpty());
        }
    }
}
