using NUnit.Framework;
using UniversitiesExam.Services.Split;

namespace NUnitTestProject1.TestsSplit
{
    public class TestSplitCorrecto
    {
        private string _stringCorrecto;
        private ISplitService _splitService;
        [Test]
        public void SeparaSplitCorrecto()
        {
            _splitService = new SplitService();
            _stringCorrecto = "patata, Marte";

            var collection = _splitService.AplicaSplit(_stringCorrecto, ',');
            Assert.AreEqual(2,collection.Length);
        }
    }
}
