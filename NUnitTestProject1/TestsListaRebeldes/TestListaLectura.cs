using System.Collections.Specialized;
using NUnit.Framework;

namespace NUnitTestProject1.TestsListaRebeldes
{
    public class TestListaLectura
    {
        [Test]
        public void LecturaCorrectaStringCollection()
        {
            StringCollection collection = new StringCollection();
            collection.AddRange(new[] {"pepe , Venus", "lola, Marte"});
            int rangoLista = 2;
            Assert.AreEqual(rangoLista,collection.Count);
        }
    }


}
