using colectii_generice_implementare;
using generiscs_collection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class QueueTests
    {
        private readonly ITestOutputHelper outputHelper;

        private Coada<Masina> masini;
        public QueueTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            masini = new Coada<Masina>();
        }

        [Fact]

        public void tests()
        {
            masini.push(new Masina("test1,1"));
            Assert.Equal(masini.peek().Data.ToString(), "test1,1");
            masini.push(new Masina("test2,2"));
            Assert.Equal(masini.peek().Data.ToString(), "test1,1");
            masini.push(new Masina("test3,3"));
            Assert.Equal(masini.peek().Data.ToString(), "test1,1");
            Assert.False(masini.isEmpty());
            Assert.Equal(masini.pop().Data.ToString(), "test1,1");
            Assert.Equal(masini.pop().Data.ToString(), "test2,2");
            Assert.Equal(masini.pop().Data.ToString(), "test3,3");
            Assert.True(masini.isEmpty());
        }
    }
}
