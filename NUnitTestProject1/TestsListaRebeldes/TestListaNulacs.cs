using System.Collections.Specialized;
using NUnit.Framework;

namespace NUnitTestProject1.TestsListaRebeldes
{
    public class TestListaNulacs
    {
        [Test]
        public void ListaRebeldesNula()
        {
            StringCollection collection = null;
            Assert.Null(collection);
        }
    }
}
